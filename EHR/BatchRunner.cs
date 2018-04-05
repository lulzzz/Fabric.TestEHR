using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace EHR
{
    class BatchRunner
    {
        internal BatchRunner(ConsoleLogger logger)
        {
            _logger = logger;
        }
        private readonly ConsoleLogger _logger;
        private const string dpsUrl = "http://localhost/DataProcessingService/";
        private const string mdsUrl = "http://localhost/MetadataService";


        internal async Task<string> GetDataMartIDByName(string dataMartName)
        {
            using (var client = CreateHttpClient(mdsUrl))
            {
                var response = await client.GetAsync($"{mdsUrl}/v1/DataMarts?$filter=Name eq '{dataMartName}'");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var jResponse = JObject.Parse(content);

                    var id = Convert.ToString(jResponse["value"][0]["Id"]);
                    return id;
                }
            }

            return null;
        }

        internal async Task<string> GetBatchDefinitionForDatamart(string dataMartId)
        {
            using (var client = CreateHttpClient(dpsUrl))
            {
                var response = await client.GetAsync($"{dpsUrl}/v1/BatchDefinitions?$filter=DataMartId eq {dataMartId}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var jResponse = JObject.Parse(content);

                    var id = Convert.ToString(jResponse["value"][0]["Id"]);
                    return id;
                }
            }

            return null;

        }

        internal async Task<int> RunBatch(string batchName, int batchDefinitionId, bool runIncremental = false)
        {
            using (var client = CreateHttpClient(dpsUrl))
            {

                _logger.AddStatus($"\nRunning {batchName} SAM");

                HttpResponseMessage response;
                if (runIncremental)
                {
                    var body = new
                    {
                        BatchDefinitionId = batchDefinitionId,
                        Status = "Queued",
                        PipelineType = "Batch",
                        LoggingLevel = "Diagnostic",
                        //LoadType = "All",
                    };

                    var content = new StringContent(body.ToString(), Encoding.UTF8, "application/json");
                    // List data response.
                    response = await client.PostAsync("v1/BatchExecutions", content); // Blocking call!
                }
                else
                {
                    var body = new
                    {
                        BatchDefinitionId = batchDefinitionId,
                        Status = "Queued",
                        PipelineType = "Batch",
                        LoggingLevel = "Diagnostic",
                        //LoadType = "All",
                        //OverrideLoadType = "Full"
                    };

                    // List data response.
                    var content = new StringContent(body.ToString(), Encoding.UTF8, "application/json");
                    response = await client.PostAsync("v1/BatchExecutions", content); // Blocking call!
                }

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var jResponse = JObject.Parse(content);
                    var batchExecutionId = Convert.ToInt32(jResponse["Id"]);
                    return batchExecutionId;
                }
                else
                {
                    var content = await response.Content.ReadAsStringAsync();
                    throw new Exception("Error running batch: " + content);
                }

                return 0;
            }
        }

        private static HttpClient CreateHttpClient(string url)
        {
            var client = new HttpClient(new HttpClientHandler()
            {
                UseDefaultCredentials = true
            });

            client.BaseAddress = new Uri(url);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        public async Task<int> WaitForBatch(string batchName, int batchExecutionId)
        {
            using (var client = CreateHttpClient(dpsUrl))
            {

                string status = "Checking";
                _logger.AddStatus($"\nChecking if {batchName} SAM is done");

                do
                {
                    var response = await client.GetAsync($"{dpsUrl}/v1/BatchExecutions({batchExecutionId})");
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var jResponse = JObject.Parse(content);

                        status = Convert.ToString(jResponse["Status"]);
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        break;
                    }
                } while (status != "Succeeded" && status != "Failed" && status != "Canceled");

                _logger.AddStatus($"\n {batchName} SAM is done with status {status}");
                return 1;
            }
        }

    }
}

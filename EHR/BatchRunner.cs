using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
        private ConsoleLogger _logger;

        internal async Task<int> RunBatch(string batchName, int batchDefinitionId, bool runIncremental = false)
        {
            var client = new HttpClient(new HttpClientHandler()
            {
                UseDefaultCredentials = true
            });
            var url = "http://localhost/DataProcessingService/";
            client.BaseAddress = new Uri(url);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

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

                // List data response.
                response = await client.PostAsJsonAsync("v1/BatchExecutions", body);  // Blocking call!
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
                response = await client.PostAsJsonAsync("v1/BatchExecutions", body);  // Blocking call!
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

        public async Task<int> WaitForBatch(string batchName, int batchExecutionId)
        {
            var client = new HttpClient(new HttpClientHandler()
            {
                UseDefaultCredentials = true
            });
            var url = "http://localhost/DataProcessingService/";
            client.BaseAddress = new Uri(url);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            string status = "Checking";
            _logger.AddStatus($"\nChecking if {batchName} SAM is done");

            do
            {
                var response = await client.GetAsync($"{url}/v1/BatchExecutions({batchExecutionId})");
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

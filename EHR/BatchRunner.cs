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
        private string _status = "";

        internal async Task<int> RunBatch(string batchName, int batchDefinitionId)
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

            var body = new
            {
                BatchDefinitionId = batchDefinitionId,
                Status = "Queued",
                PipelineType = "Batch",
                LoggingLevel = "Diagnostic",
                //LoadType = "All",
                //OverrideLoadType = "Full"
            };

            _status += $"\nRunning {batchName} SAM";
            // List data response.
            HttpResponseMessage response = await client.PostAsJsonAsync("v1/BatchExecutions",body);  // Blocking call!

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var jResponse = JObject.Parse(content);
                var batchExecutionId = Convert.ToInt32(jResponse["Id"]);
                return batchExecutionId;
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
            _status += $"\nChecking if {batchName} SAM is done";

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

            _status += $"\n {batchName} SAM is done with status {status}";
            return 1;
        }

        public string GetStatus()
        {
            return _status;
        }
    }
}

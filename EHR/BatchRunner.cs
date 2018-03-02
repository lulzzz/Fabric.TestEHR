using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EHR
{
    class BatchRunner
    {
        internal async Task RunBatch(int batchDefinitionId)
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
                LoadType = "All",
                OverrideLoadType = "Full"
            };

            // List data response.
            HttpResponseMessage response = await client.PostAsJsonAsync("v1/BatchExecutions",body);  // Blocking call!

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Success");
            }
        }
    }
}

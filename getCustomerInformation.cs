using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using GetCustomerInformation = brandwerk.Function.Classes.GetCustomerInformationResponse;


namespace brandwerk.Function
{
    public static class getCustomerInformation
    {
        [FunctionName("getCustomerInformation")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            GetCustomerInformation response = new GetCustomerInformation();

            dynamic jsonResponse = JsonConvert.SerializeObject(response);

            return (ActionResult)new OkObjectResult(jsonResponse);
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class myfunctionmiller
    {
        private readonly ILogger<myfunctionmiller> _logger;

        public myfunctionmiller(ILogger<myfunctionmiller> logger)
        {
            _logger = logger;
        }

        [Function("myfunctionmiller")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}

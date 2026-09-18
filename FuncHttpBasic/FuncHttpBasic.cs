using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace github.learn.actions;

public class FuncHttpBasic
{
    private readonly ILogger<FuncHttpBasic> _logger;

    public FuncHttpBasic(ILogger<FuncHttpBasic> logger)
    {
        _logger = logger;
    }

    [Function("FuncHttpBasic")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}
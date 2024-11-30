using Microsoft.AspNetCore.Mvc;
using ReviewerSuperBugWebApi.Services;

namespace ReviewerSuperBugWebApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class BugsController(BugHostedService bugHostedService) : ControllerBase
{
    private string? _s;
    
    [HttpGet]
    public async Task<IActionResult> Test()
    {
        bugHostedService.CheckNullableArgs(_s ?? "abc");
        var test = bugHostedService.ReturnNull() ?? throw new Exception();
        return Ok();
    }
}
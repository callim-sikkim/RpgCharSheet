using Microsoft.AspNetCore.Mvc;

namespace RpgCharSheet.ApiService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CharacterSheetController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() 
        => Ok("get works");
    
    [HttpPost("Update")]
    public IActionResult Update() 
        => Ok("update works");
    
    [HttpPost("Create")]
    public IActionResult Create() 
        => Ok("create works");
    
    [HttpDelete]
    public IActionResult Delete() 
        => Ok("delete works");
}
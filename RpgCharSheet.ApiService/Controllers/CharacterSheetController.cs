using Microsoft.AspNetCore.Mvc;

namespace RpgCharSheet.ApiService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CharacterSheetController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() 
        => Ok("działa");
}
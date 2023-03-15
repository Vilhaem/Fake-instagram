using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Fake_instagram.Controllers;

[ApiController]
[Route("[controller]")]
public class UpdateProfilePictureController : ControllerBase
{
    private readonly ILogger<UpdateProfilePictureController> _logger;
    public UpdateProfilePictureController(ILogger<UpdateProfilePictureController> logger)
    {
        _logger = logger;
    }
    [HttpPost]
    [Route("update-profile-picture")]
    // public async Task<IActionResult> UpdateProfilePicture([FromBody] UpdateProfilePictureRequest request)
    // {
    //     if (request.)
    // }
    public class UpdateProfilePictureRequest
    {
        public string FilePath { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
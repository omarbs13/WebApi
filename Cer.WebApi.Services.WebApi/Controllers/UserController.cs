using Cer.WebApi.Application.Interface;
using Cer.WebApi.Application.Model;
using Microsoft.AspNetCore.Mvc;

namespace Cer.WebApi.Services.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserApplication _userApplication;
        public UserController(IUserApplication userApplication)
        {
            _userApplication = userApplication;
        }

        [HttpPost]
        public IActionResult Insert([FromBody]UserModel userModel)
        {
            if (userModel == null)
                return BadRequest();
            var response = _userApplication.Insert(userModel);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
    }
}
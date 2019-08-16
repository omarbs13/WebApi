using Cer.WebApi.Application.Interface;
using Cer.WebApi.Application.Model;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        #region "Métodos Sincronos"

        /// <summary>
        /// Insert user into DB
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Insert([FromBody]UserAddModel userModel)
        {
            if (userModel == null)
                return BadRequest();
            var response = _userApplication.Insert(userModel);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut]
        public IActionResult Update([FromBody]UserAddModel userModel)
        {
            if (userModel == null)
                return BadRequest();
            var response = _userApplication.Update(userModel);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("{userId}")]
        public IActionResult Delete(int userId)
        {
            if (userId <= 0)
                return BadRequest();
            var response = _userApplication.Delete(userId);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet]
        [Route("[action]/{userId}")]
        public IActionResult GetById(int userId)
        {
            if (userId <= 0)
                return BadRequest();
            var response = _userApplication.GetById(userId);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAll()
        {
            var response = _userApplication.GetAll();
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }       

        [HttpGet]
        [Route("[action]")]
        public IActionResult Find([FromQuery]UserModel user)
        {
            var response = _userApplication.Find(x => x.UserName == user.UserName && x.Password == user.Password);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        #endregion

        #region Métodos Asincronos
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> InsertAsync([FromBody]UserAddModel userModel)
        {
            if (userModel == null)
                return BadRequest();
            var response = await _userApplication.InsertAsync(userModel);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateAsync([FromBody]UserAddModel userModel)
        {
            if (userModel == null)
                return BadRequest();
            var response = await _userApplication.UpdateAsync(userModel);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete]
        [Route("[action]/{userId}")]
        public async Task<IActionResult> DeleteAsync(int userId)
        {
            if (userId <= 0)
                return BadRequest();
            var response = await _userApplication.DeleteAsync(userId);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet]
        [Route("[action]/{userId}")]
        public async Task<IActionResult> GetByIdAsync(int userId)
        {
            if (userId <= 0)
                return BadRequest();
            var response = await _userApplication.GetByIdAsync(userId);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _userApplication.GetAllAsync();
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
                      

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> FindAsync([FromQuery]UserModel user)
        {
            var response = await _userApplication.FindAsync(x => x.UserName == user.UserName && x.Password == user.Password);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
        #endregion
    }
}
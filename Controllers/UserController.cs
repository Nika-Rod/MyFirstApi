using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Communication.Requests;
using MyFirstApi.Communication.Responses;

namespace MyFirstApi.Controllers
{
    public class UserController : MyFirstApiBaseController
    {
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof (string), StatusCodes.Status400BadRequest)]
        public IActionResult Get(int id)
        {
            var response = new User
            {
                Id = 1,
                Age = 7,
                Name = "Veronica"
            };

            var key = GetCustomKey();

            return Ok(key);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
        public IActionResult Create(RequestRegisterUserJson request)
        {
            var response = new ResponseRegisteredUserJson
            {
                Id = 1,
                Name = request.Name,
            };

            return Created(string.Empty, response);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update(RequestUpdateUserProfileJson request)
        {
            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete()
        {
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        public IActionResult GetAll() 
        {
            var response = new List<User>(){
                new User {Id = 1, Age = 7, Name = "Veronica" },
                new User {Id = 2, Age = 7, Name = "Welisson" }
            };

            var key = GetCustomKey();
            return Ok(key);
        }

        [HttpPut("change-password")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult ChangePassword(RequestChangePasswordJson request)
        {
            return NoContent();
        }
    }
}

using Api.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Api.Data.Converter;
using Microsoft.AspNetCore.Authorization;

namespace Api.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        private IUserBusiness _userBusiness;

        public UserController(ILogger<UserController> logger, IUserBusiness userBusiness)
        {
            _logger = logger;
            _userBusiness = userBusiness;
        }

        [HttpGet]
        [ProducesResponseType((200), Type = typeof(List<UserVO>))]
        [ProducesResponseType((204))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]

        public IActionResult Get()
        {
            return Ok(_userBusiness.FindAll());
        }
        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(UserVO))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        public IActionResult Get(long id)
        {
            var user = _userBusiness.FindByID(id);
            if (user == null) return NotFound();
            return Ok(user);
        }
        [HttpPost]
        [ProducesResponseType((200), Type = typeof(UserVO))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        public IActionResult Post([FromBody] UserVO user)
        {
            if (user == null) return BadRequest();
            return Ok(_userBusiness.Create(user));
        }
        [HttpPut]
        [ProducesResponseType((200), Type = typeof(List<UserVO>))]
        [ProducesResponseType((204))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        public IActionResult Put([FromBody] UserVO user)
        {
            if (user == null) return BadRequest();
            return Ok(_userBusiness.Update(user));
        }
        [HttpDelete("{id}")]
        [ProducesResponseType((204))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        public IActionResult Delete(long id)
        {
            _userBusiness.Delete(id);
            return NoContent();
        }
    }
}

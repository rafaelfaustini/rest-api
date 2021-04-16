using Api.Model;
using Api.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Converter;

namespace Api.Controllers
{
    [ApiVersion("1")]
    [ApiController]
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
        public IActionResult Get()
        {
            return Ok(_userBusiness.FindAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var user = _userBusiness.FindByID(id);
            if (user == null) return NotFound();
            return Ok(user);
        }
        [HttpPost]
        public IActionResult Post([FromBody] UserVO user)
        {
            if (user == null) return BadRequest();
            return Ok(_userBusiness.Create(user));
        }
        [HttpPut]
        public IActionResult Put([FromBody] UserVO user)
        {
            if (user == null) return BadRequest();
            return Ok(_userBusiness.Update(user));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _userBusiness.Delete(id);
            return NoContent();
        }
    }
}

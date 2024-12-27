using AccountingApp.BLL.Forms;
using AccountingApp.BLL.Interfaces;
using AccountingApp.BLL.Mappers;
using AccountingApp.DB.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService service) : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
        public IActionResult Create([FromBody] UserForm user)
        {
            try
            {
                User? result = service.Create(user);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] UserUpdateForm user)
        {
            try
            {
                service.Update(user);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

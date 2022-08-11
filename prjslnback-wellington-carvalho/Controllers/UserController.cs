using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prjslnback_wellington_carvalho.Data;
using prjslnback_wellington_carvalho.Models;
using System.Linq;
using System.Threading.Tasks;

namespace prjslnback_wellington_carvalho.Controllers
{
    [ApiController]
    [Route("v1/User")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("Login")]
        public async Task<ActionResult<UserDTO>> Get([FromServices] DataBaseContext context, string userName, string password)
        {
            var userData = await context.User.Where(x => x.UserName == userName && x.password == password).FirstOrDefaultAsync();
            if (userData == null) { return BadRequest("Usuario ou senha invalidos"); }
            return userData;
        }

        [HttpPost]
        [Route("Sign")]
        public async Task<ActionResult<UserDTO>> Post(
           [FromServices] DataBaseContext context,
           string userName, string password)
        {
            UserValidator userGenerator = new UserValidator();
            UserDTO model = userGenerator.GenerateUser(userName, password);

            if (ModelState.IsValid)
            {
                context.User.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}



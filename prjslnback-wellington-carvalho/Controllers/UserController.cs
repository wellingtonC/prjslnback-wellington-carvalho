using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prjslnback_wellington_carvalho.Data;
using prjslnback_wellington_carvalho.Models;
using prjslnback_wellington_carvalho.Services;
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
        public async Task<ActionResult<User>> Get([FromServices] DataContext context, string userName, string password)
        {
            var userData = await context.User.Where(x => x.UserName == userName && x.password == password).FirstAsync();
            if (userData == null) { return BadRequest("Usuario ou senha invalidos"); }
            return userData;
        }

        [HttpPost]
        [Route("Sign")]
        public async Task<ActionResult<User>> Post(
           [FromServices] DataContext context,
           string userName, string password)
        {
            PasswordValidations passwordValid = new PasswordValidations();
            if (passwordValid.PasswordValidator(password) == true)
            {

                TokenValid tokenValidate = TokenService.GenerateToken(userName);
                User model = new User() { UserName = userName, password = password, Token = tokenValidate.tokenValue, expirationDate= tokenValidate.expiresDate };

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

            return BadRequest("senha invalida");

        }
    }
}


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
        [Route("")]
        public async Task<ActionResult<User>> Get([FromServices] DataContext context, string username, string password)
        {            
            var categories = await context.User.Where(x => x.userName == username && x.password == password).FirstAsync();
            if (categories == null) { return BadRequest("Usuario ou senha invalidos"); }
            return categories;
        }

        [HttpPost]
        [Route("Sign")]
        public async Task<ActionResult<User>> Post(
           [FromServices] DataContext context,
           string username , string password)
        {
            var validatepassword=password.ToArray();

            int trys= 0;
            for (int i = 0; i <= password.Length-1; i++)
            {
                if (i >= 1)
                {
                    if (validatepassword[i] == validatepassword[i - 1])
                    {
                        trys++;
                        if (trys >= 2) 
                        {
                            return BadRequest("A senha não pode  conter muitos caracteres repetidos");
                        }
                    }
                }
            }
            var token = TokenService.GenerateToken(username);
            User model = new User(){ userName=username, password =password, Token = token};

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


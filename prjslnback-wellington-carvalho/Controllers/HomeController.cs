using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using prjslnback_wellington_carvalho.repositories;
using prjslnback_wellington_carvalho.Services;
using Microsoft.AspNetCore.Authorization;

namespace prjslnback_wellington_carvalho.Controllers
{
    [Route("v1/account")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        [Route("Login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate( string username, string password) 
        {
            var user = UserRepositories.Get(username, password);

            if (user == null) 
            {
                return NotFound(new { message = "Usuario ou senha invalidos" });
            }
            var token = TokenService.GenerateToken(user);
            user.password = "";
            return new
            {
                user = user.id,
                       user.userName,
                token = token
            };
        }
    }
}

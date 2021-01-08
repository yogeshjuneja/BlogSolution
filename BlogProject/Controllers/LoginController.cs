using BlogProject.Services;
using Microsoft.AspNetCore.Mvc;
using ModelLayer;

namespace BlogProject.Controllers
{
    [ApiController]
    [Route("api/[controller]/[Action]")]

    public class LoginController : ControllerBase
    {
        IAuthenticationManager AuthenticationManager;
        public LoginController(IAuthenticationManager objIAuthenticationManager)
        {
            AuthenticationManager = objIAuthenticationManager;
        }
        [HttpPost]
        public IActionResult SignIn(LoginModel objLoginModel)
        {
            if (ModelState.IsValid)
            {
                string AuthToken = AuthenticationManager.Authenticate(objLoginModel);
                if (!string.IsNullOrEmpty(AuthToken))
                    return Ok(AuthToken);
                else
                    return Unauthorized("Invalid Credentials");
            }
            else
                return BadRequest(ModelState);
        }

    }

}

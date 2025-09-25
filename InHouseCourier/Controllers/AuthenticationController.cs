using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InHouseCourier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManger;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthenticationController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManger = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }





    }
}

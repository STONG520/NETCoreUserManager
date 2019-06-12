using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PhoneWEBAPI.Models;

namespace PhoneWEBAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public UserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="loginUser"></param>
        /// <returns>0 OK 1：用户名错误 2：密码错误</returns>
        [HttpPost]
        public async Task<string> login([FromBody]LoginUser loginUser)
        {
           var myUser= await userManager.FindByNameAsync(loginUser.userName);
            if (myUser == null)
            {
                return "1";
            }
            else {
                var result = await signInManager.PasswordSignInAsync(myUser, loginUser.password, false, false);
                if (result.Succeeded) {
                    return "0";
                }
                return "2";
            }
          
        }
        [HttpPost]
        public async Task<bool> addUser([FromBody] LoginUser loginUser) {
            if (!ModelState.IsValid)
            {
                return false;
            }

            var user = new ApplicationUser
            {
                UserName=loginUser.userName,
                PasswordHash=loginUser.password
            };

            var result = await userManager.CreateAsync(user,loginUser.password);

            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }

        [HttpPost]
        public string updateUser([FromBody] LoginUser loginUser) {
            return "";
        }
    }
}
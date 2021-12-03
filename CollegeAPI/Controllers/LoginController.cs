using CollegeAPI.Models;
using CollegeAPI.Models.DBConnection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CollegeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {       
        private SignInManager<UserRgister> _signInManager;
        private UserManager<UserRgister> _userManager;
        public LoginController(UserManager<UserRgister> userManager,SignInManager<UserRgister> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        // GET: api/<LoginController> bjhghgg
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LoginController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoginController>HttpPost]
        [HttpPost]
        [Route("Register")]
        public async Task<object> RegisterUser([FromBody] Register user)
        {
            try
            {
                var _user = new UserRgister() { NormalizedUserName = user.Name, UserName = user.Email, Email = user.Email, CretedDate = DateTime.Now };
                var result = await _userManager.CreateAsync(_user, user.Password);
                if (result.Succeeded)
                {
                    return await Task.FromResult("User has created successfully.");
                }
                return await Task.FromResult(string.Join(",", result.Errors.Select(x => x.Description)));
            }
            catch (Exception ex) {
                return await Task.FromResult(ex.Message);
            }
        }
        

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

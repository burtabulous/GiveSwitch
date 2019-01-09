using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GiveSwitch.Data.Interfaces;
using GiveSwitch.Data.Models;

namespace GiveSwitch.Areas.Users.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UserApiController : ControllerBase
    {
        private readonly IUserProvider userProvider;

        public UserApiController(IUserProvider userProvider)
        {
            this.userProvider = userProvider;
        }

        // GET: api/TestUser
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return userProvider.GetUsers();
            
        }

        // GET: api/TestUser/5
        [HttpGet("{id}", Name = "Get")]
        public User Get(int id)
        {
            return userProvider.GetUserById(id);
        }

        // POST: api/TestUser
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/TestUser/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

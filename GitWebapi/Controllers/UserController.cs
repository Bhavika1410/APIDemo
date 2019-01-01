

using System.Collections.Generic;
using System.Linq;
using GitWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Web.Http.Cors;

namespace GitWebApi.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [Route("api/[controller]")]

    public class UserController : ControllerBase
    {
        [HttpGet("UserList")]
        public ActionResult GetUsers()
        {
            using (var db = new WebApiContext())
            {
                var users = db.Users.ToList();
                if (users != null)
                    return Ok(users);
                return NotFound("Error while getting user list");
            }
        }

        [HttpPost]
        public ActionResult AddUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (var db = new WebApiContext())
            {
                var id = db.Users.Add(user);
                if (id != null)
                    return Ok(id);
                return NotFound("Error while adding user");
            }
        }
    }
}
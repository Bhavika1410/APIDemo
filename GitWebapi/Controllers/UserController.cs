

using System.Collections.Generic;
using System.Linq;
using GitWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Web.Http.Cors;
using System;

namespace GitWebApi.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [Route("api/[controller]")]

    public class UserController : ControllerBase
    {
        // GET api/values
        /// <summary>
        /// Get list of users
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetUsers")]
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

        // GET api/values
        /// <summary>
        /// Add User
        /// </summary>
        /// <returns></returns>
        [Route("AddUser")]
        [HttpPost]
        public ActionResult AddUser([FromBody]User user)
        {
            try
            {
                using (var db = new WebApiContext())
                {
                    user.IsActive = true;
                    user.IsDelete = false;
                    var id = db.Users.Add(user);
                    db.SaveChanges();
                    var list = db.Users.ToList();
                    if (id != null)
                        return Ok(id);

                }
            }
            catch
            {
                // Console.log(ex);
            }
            return NotFound("Error while adding user");
        }
    }
}
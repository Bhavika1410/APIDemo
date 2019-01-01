using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GitWebApi.Models;
using GitWebApi;
using System.Web.Http.Cors;

namespace GitWebApi.Controllers
{
    // [Authorize]
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        // GET api/values
        /// <summary>
        /// List of all Products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Get()
        {
            using(var db=new WebApiContext()){
                var products = db.Products.ToList();
                return Ok(products);
            }
        }

        // GET api/values/5
        /// <summary>
        /// Details of product based on specific ID
        /// </summary>
        /// <param name="id">Mandatory</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }        
    }
}

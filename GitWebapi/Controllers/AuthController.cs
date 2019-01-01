using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace GitWebApi.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        [HttpPost("token")]
        public IActionResult Token()
        {
            // string tokenString = "test";
            var header = Request.Headers["Authorization"];
            if (header.ToString().StartsWith("Basic"))
            {
                var credValue = header.ToString().Substring("Basic ".Length).Trim();
                var usernameAndPassEnc = Encoding.UTF8.GetString(Convert.FromBase64String(credValue));
                var usernameAndPass = usernameAndPassEnc.Split(":");
                //check username and password
                if (usernameAndPass[0] == "Admin" && usernameAndPass[1] == "pass")
                {
                    var claimsdata = new[] { new Claim(ClaimTypes.Name, usernameAndPass[0]) };
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("dsgjkhagjHLsfaKDLJajLHAJDfkhjdaKfhsdjkfghsdj"));
                    var signInCred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
                    var token = new JwtSecurityToken(
                        issuer: "mysite.com",
                        audience: "mysite.com",
                        expires: DateTime.Now.AddMinutes(1),
                        claims: claimsdata,
                        signingCredentials: signInCred
                    );

                    var tokenString = new JwtSecurityTokenHandler().WriteToken(token); //header_data + claims_data + Signature_details
                    return Ok(tokenString);
                }
            }
            return BadRequest("Wrong Request");
        }
    }
}
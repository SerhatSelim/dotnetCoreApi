using Business.RestHelper;
using Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using System;

using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/authentication")]
    public class JwtAuthenticationController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet]
        [Route("login")]
        public ServiceResult<TokenDto> Authenticate(string email, string password)
        {

            var tokenHandler = new JwtSecurityTokenHandler();
            var keyJObject = JObject.Parse(System.IO.File.ReadAllText("appsettings.json"));
            var secretKey = keyJObject.SelectToken("Secret").Value<JObject>().SelectToken("Key").Value<string>();
            var key = Encoding.ASCII.GetBytes(secretKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("userId", "1"),

                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

             
            var token = tokenHandler.CreateToken(tokenDescriptor);

            Response.Cookies.Append("token", tokenHandler.WriteToken(token));

            var response = tokenHandler.WriteToken(token).ToString();

            return new ServiceResult<TokenDto>(response);
        }
    }
}

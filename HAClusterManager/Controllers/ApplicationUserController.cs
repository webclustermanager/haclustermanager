using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using HAClusterManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Renci.SshNet;

namespace HAClusterManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly ApplicationSettings _appSettings;

        public ApplicationUserController(IOptions<ApplicationSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [HttpPost]
        [Route("Login")]
        //POST : /api/ApplicationUser/Login
        public ActionResult Login(LoginModel model)
        {
            using (var client = new SshClient(model.HostIP, model.UserName, model.Password))
            {
                try
                {
                    client.Connect();
                    if (client.IsConnected)
                    {
                        client.Disconnect();
                        var tokenDescriptor = new SecurityTokenDescriptor
                        {
                            Expires = DateTime.Now.AddDays(1),
                            SigningCredentials = new SigningCredentials(
                                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)
                        };

                        var tokenHandler = new JwtSecurityTokenHandler();
                        var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                        var token = tokenHandler.WriteToken(securityToken);

                        return Ok(new { token });
                    }
                    else
                        return BadRequest(new { message = "Unexpected error..." });

                }
                catch (Exception ex)
                {
                    return BadRequest(new { message = ex.Message });
                }
            }

        }
    }
}
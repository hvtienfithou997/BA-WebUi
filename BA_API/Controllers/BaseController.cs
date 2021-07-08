using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace BA_API.Controllers
{
    public class BaseController : Controller
    {
        public static string BuildToken(string app_id, string user_id, IEnumerable<string> roles, string full_name, string team, string ip)
        {
            try
            {
                var claims = new List<Claim>() {
                    new Claim(JwtRegisteredClaimNames.NameId, user_id),
                    new Claim(JwtRegisteredClaimNames.GivenName, full_name),
                    new Claim("ipad", ip),
                    new Claim("team", team),
                    new Claim("app_id", app_id)
                };
                if (roles != null && roles.Count() > 0)
                    claims.AddRange(roles.Select(role => new Claim(ClaimsIdentity.DefaultRoleClaimType, role)));
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("_Xalo244a|XMEDIA_XQLCungUngNhanLuc@2020KEY"));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken("https://auth.xmedia.vn", "https://auth.xmedia.vn", claims, expires: DateTime.Now.AddMinutes(Convert.ToInt32(7200)),
                    signingCredentials: creds);
                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return "";
        }
    }
}
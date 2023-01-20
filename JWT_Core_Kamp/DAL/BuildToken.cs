using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace JWT_Core_Kamp.DAL
{
    public class BuildToken
    {

        public string CreateToken()
        {
            //var bytes = Encoding.UTF8.GetBytes("aspnetcoreprojekampi");
            //SymmetricSecurityKey key=new SymmetricSecurityKey(bytes);
            //SigningCredentials credentials=new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
            //JwtSecurityToken token = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost", notBefore: DateTime.Now,expires:DateTime.Now.AddMinutes(1), signingCredentials: credentials);
            //JwtSecurityTokenHandler handler= new JwtSecurityTokenHandler();
            //return handler.WriteToken(token);



            var bytes = Encoding.UTF8.GetBytes("aspnetcoreprojectcamp");
            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken token = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost", notBefore: DateTime.Now, expires: DateTime.Now.AddMinutes(1), signingCredentials: credentials);
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return handler.WriteToken(token);


        }


    }
}

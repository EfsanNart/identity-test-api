using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace identity_test_api
{
    public static class Helper
    {
        public static string GenerateJwtToken(string email, IConfiguration configuration)
        {
            // appsettings.json içindeki Key, Issuer ve Audience değerlerini oku
            var key = configuration["Jwt:Key"];
            var issuer = configuration["Jwt:Issuer"];
            var audience = configuration["Jwt:Audience"];

            if (string.IsNullOrEmpty(key) || key.Length < 16)
            {
                throw new ArgumentException("JWT key must be at least 128 bits (16 characters).");
            }

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, email)
            };

            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

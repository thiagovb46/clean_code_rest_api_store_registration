using Application.ViewModels;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Application.Services.TokenServices
{
    public class TokenService : ITokenService
    {
        private readonly ISettings _settings;

        public TokenService(ISettings settings)
        {
            _settings = settings;

        }
        public string GenerateToken(UserViewModelLogin usuario)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_settings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, usuario.Email),
                    new Claim(ClaimTypes.Role,usuario.Email)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new  SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}

using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace RentAndSell.Car.API.Services
{
    public class YetkiKontrolYaklayicisi : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public YetkiKontrolYaklayicisi(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder) : base(options, logger, encoder)
        {

        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (Request.Headers.ContainsKey("Authorization"))
            {
                string authorization = Request.Headers["Authorization"];
                string base64Encode = authorization.Split("Basic ")[1];
                string authDecode = Encoding.UTF8.GetString(Convert.FromBase64String(base64Encode));
                string[] credentials = authDecode.Split(':');
                string username = credentials[0];
                string password = credentials[1];

                if(username == "admin" && password == "123456*Admin")
                {
                    List<Claim> claims = new List<Claim>() {
                        new Claim(ClaimTypes.NameIdentifier, "1001"),
                        new Claim(ClaimTypes.Name, username),
                        new Claim(ClaimTypes.Email, username + "@bilgeadam.com")
                        };

                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, Scheme.Name);
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    AuthenticationTicket gecisBileti = new AuthenticationTicket(claimsPrincipal, Scheme.Name);

                    return AuthenticateResult.Success(gecisBileti);
                }


                return AuthenticateResult.Fail("Kullanıcı adı veya şifreniz yanlıştır.");

            }

            return AuthenticateResult.Fail("Yetksizi giriş denemesi");
            
        }
    }
}

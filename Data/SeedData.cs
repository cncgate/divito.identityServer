using System;
using System.Linq;
using System.Security.Claims;
using IdentityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MXP.IdentityServer.Data
{
    public class SeedData
    {
        public static void EnsureSeedData(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = scope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.Migrate();

                var userMgr = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                var alice = userMgr.FindByNameAsync("alice").Result;
                alice = SeedAliceData(userMgr, alice);

                var bob = userMgr.FindByNameAsync("bob").Result;
                bob = SeedBobData(userMgr, bob);

                var dmitry = userMgr.FindByNameAsync("dsmirnov").Result;
                dmitry = SeedDmitryData(userMgr, dmitry);
            }
        }

        private static ApplicationUser SeedBobData(UserManager<ApplicationUser> userMgr, ApplicationUser bob)
        {
            if (bob == null)
            {
                bob = new ApplicationUser
                {
                    UserName = "bob"
                };
                var result = userMgr.CreateAsync(bob, "Pass123$").Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }

                result = userMgr.AddClaimsAsync(bob, GetBobClaims()).Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }
                Console.WriteLine("bob created");
            }
            else
            {
                Console.WriteLine("bob already exists");
                //check that claims created too
                var claims = userMgr.GetClaimsAsync(bob).Result;
                if (!claims.Any())
                {
                    var result = userMgr.AddClaimsAsync(bob, GetBobClaims()).Result;
                    if (!result.Succeeded)
                    {
                        throw new Exception(result.Errors.First().Description);
                    }
                    Console.WriteLine("bob claims created");
                }
            }

            return bob;
        }

        private static ApplicationUser SeedAliceData(UserManager<ApplicationUser> userMgr, ApplicationUser alice)
        {
            if (alice == null)
            {
                alice = new ApplicationUser
                {
                    UserName = "alice"
                };
                var result = userMgr.CreateAsync(alice, "Pass123$").Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }

                result = userMgr.AddClaimsAsync(alice, GetAliceClaims()).Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }
                Console.WriteLine("alice created");
            }
            else
            {

                Console.WriteLine("alice already exists");
                //check that claims created too
                var claims = userMgr.GetClaimsAsync(alice).Result;
                if (!claims.Any())
                {
                    foreach (var item in GetAliceClaims()) {
                        var added = userMgr.AddClaimAsync(alice, item).Result;                        
                    }

                    //var result = userMgr.AddClaimsAsync(alice, GetAliceClaims()).Result;
                    //if (!result.Succeeded)
                    //{
                    //    throw new Exception(result.Errors.First().Description);
                    //}
                    //Console.WriteLine("bob claims created");
                }
            }

            return alice;
        }

        private static ApplicationUser SeedDmitryData(UserManager<ApplicationUser> userMgr, ApplicationUser user)
        {
            if (user == null)
            {
                user = new ApplicationUser
                {
                    UserName = "dsmirnov"
                };
                var result = userMgr.CreateAsync(user, "Ddd123!").Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }

                result = userMgr.AddClaimsAsync(user, GetDmitryClaims()).Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }
                Console.WriteLine("dmitry created");
            }
            else
            {
                Console.WriteLine("dmitry already exists");
                //check that claims created too
                var claims = userMgr.GetClaimsAsync(user).Result;
                if (!claims.Any())
                {
                    var result = userMgr.AddClaimsAsync(user, GetDmitryClaims()).Result;
                    if (!result.Succeeded)
                    {
                        throw new Exception(result.Errors.First().Description);
                    }
                    Console.WriteLine("dmitry claims created");
                }
            }

            return user;
        }

        private static Claim[] GetDmitryClaims()
        {
            return new Claim[]{
                        new Claim(JwtClaimTypes.Name, "Dmitry Smirnov"),
                        new Claim(JwtClaimTypes.GivenName, "Dmitry"),
                        new Claim(JwtClaimTypes.FamilyName, "Smirnov"),
                        new Claim(JwtClaimTypes.Email, "dmitry@iosapps.pro"),
                        new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        new Claim(JwtClaimTypes.WebSite, "http://mxp.lv"),
                        new Claim(JwtClaimTypes.Address, @"{ 'street_address': '50 A.Deglava iela', 'locality': 'Riga', 'postal_code': 1050, 'country': 'Latvia' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
                    };
        }

        private static Claim[] GetAliceClaims()
        {
            return new Claim[]{
                        new Claim(JwtClaimTypes.Name, "Alice Smith"),
                        new Claim(JwtClaimTypes.GivenName, "Alice"),
                        new Claim(JwtClaimTypes.FamilyName, "Smith"),
                        new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                        new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                        new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
                    };
        }

        private static Claim[] GetBobClaims()
        {
            return new Claim[]{
                            new Claim(JwtClaimTypes.Name, "Bob Smith"),
                        new Claim(JwtClaimTypes.GivenName, "Bob"),
                        new Claim(JwtClaimTypes.FamilyName, "Smith"),
                        new Claim(JwtClaimTypes.Email, "BobSmith@email.com"),
                        new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        new Claim(JwtClaimTypes.WebSite, "http://bob.com"),
                        new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json),
                        new Claim("location", "somewhere")
                        };
        }
    }
}

using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace MXP.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                //new ApiResource("api1", "My API")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            // OpenID Connect implicit flow client (MVC)
            var mvcClient = new Client
            {
                ClientId = "mvc",
                ClientName = "MXP.LV",
                AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,

                RequireConsent = false,

                ClientSecrets =
                {
                    new Secret("secret".Sha256())
                },

                RedirectUris = {
                    "http://localhost:8080/signin-oidc",
                    "http://localhost:5000/signin-oidc",
                    "http://mxp2.azurewebsites.net/signin-oidc"
                },

                PostLogoutRedirectUris = {
                    "http://localhost:5000/signout-callback-oidc",
                    "http://mxp2.azurewebsites.net/signout-callback-oidc"
                },

                AllowedScopes = new List<string>
                {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile
                },

                AllowOfflineAccess = true
            };

            var mvcMxpDevelopmentClient = new Client
            {
                ClientId = "mxp_mvc",
                ClientName = "MXP",
                AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,

                RequireConsent = false,

                ClientSecrets =
                {
                    new Secret("mvcSecret".Sha256())
                },

                RedirectUris = {
                    "http://localhost:5000/signin-oidc",
                    "https://localhost:5001/signin-oidc"
                },
                PostLogoutRedirectUris = {
                    "http://localhost:5000/signout-callback-oidc",
                    "https://localhost:5001/signout-callback-oidc"
                },

                AllowedScopes = new List<string>
                {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile
                },
                AllowOfflineAccess = true
            };

            return new List<Client>
            {
                mvcClient,
                mvcMxpDevelopmentClient
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }
    }
}

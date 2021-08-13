using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };
        public static IEnumerable<ApiScope> GetApis() =>
            new List<ApiScope>
            {
                new ApiScope("ApiOne", "My API1"),
                new ApiScope("ApiTwo", "My Api2"),
            };

        public static IEnumerable<Client> GetClients() =>
            new List<Client> 
            {
                new Client
                {
                    ClientId = "client_id",
                    ClientSecrets = { new Secret("client_secret".Sha256())},

                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    AllowedScopes = { "ApiOne" }
                },

                new Client
                {
                    ClientId = "client_id_mvc",
                    ClientSecrets = { new Secret("client_secret_mvc".Sha256())},

                    AllowedGrantTypes = GrantTypes.Code,

                    RedirectUris = { "https://localhost:44384/signin-oidc" },

                    AllowedScopes = { 
                        "ApiOne","ApiTwo",
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile
                    },

                    RequireConsent = false

                    
                }
            };
    }
}

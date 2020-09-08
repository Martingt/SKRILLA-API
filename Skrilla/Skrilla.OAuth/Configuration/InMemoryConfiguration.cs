using System;
using System.Collections.Generic;
using IdentityServer4.Models;
using IdentityServer4.Test;
using IdentityServer4;

namespace Skrilla.OAuth.Configuration
{
    public class InMemoryConfiguration
    {
        public static IEnumerable<ApiResource> ApiResources()
        {
            return new[] {
                    new ApiResource("skrilla", "Skrilla")
                };
        }

        public static IEnumerable<IdentityResource> IdentityResources()
        {
            return new IdentityResource[] {
                    new IdentityResources.OpenId(),
                    new IdentityResources.Profile()
                };
        }

        public static IEnumerable<ApiScope> ApiScopes()
        {
            return new[] {
                    new ApiScope("skrilla", "Skrilla")
                };
        }


        public static IEnumerable<Client> Clients()
        {
            return new[] {
                    new Client
                    {
                        ClientId = "skrilla",
                        ClientSecrets = new [] { new Secret("secret".Sha256()) },
                        AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                        AllowedScopes = new [] { "skrilla" }
                    },

                    new Client
                    {
                        ClientId = "skrilla_implicit",
                        ClientSecrets = new [] { new Secret("secret".Sha256()) },
                        AllowedGrantTypes = GrantTypes.Implicit,
                        AllowedScopes = new [] {
                            IdentityServerConstants.StandardScopes.OpenId,
                            IdentityServerConstants.StandardScopes.Profile,
                            "skrilla" },
                        RedirectUris = new [] { "http://localhost:5000" }, // Se redirecciona cuando se obtiene acceso en react
                        PostLogoutRedirectUris = new [] {""}
                    }
                };
        }

        public static IEnumerable<TestUser> Users()
        {
            return new[] {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "m.garcia.tejeda@gmail.com",
                    Password = "password"

                }
            };

        }
    }
}

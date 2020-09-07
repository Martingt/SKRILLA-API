using System;
using System.Collections.Generic;
using IdentityServer4.Models;
using IdentityServer4.Test;

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

        public static IEnumerable<Client> Clients()
        {
            return new[] {
                    new Client
                    {
                        ClientId = "skrilla",
                        ClientSecrets = new [] { new Secret("secret".Sha256()) },
                        AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                        AllowedScopes = new [] { "skrilla" }
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

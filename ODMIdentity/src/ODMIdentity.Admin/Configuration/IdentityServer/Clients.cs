﻿using System.Collections.Generic;
using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using Microsoft.Extensions.Configuration;
using ODMIdentity.Admin.Configuration.Constants;
using ODMIdentity.Admin.Configuration.Interfaces;

namespace ODMIdentity.Admin.Configuration.IdentityServer

{
    public class Clients
    {
        public static IEnumerable<Client> GetAdminClient(IAdminConfiguration adminConfiguration, IConfiguration configuration)
        {

            return new List<Client>
            {

	            ///////////////////////////////////////////
	            // ODMIdentity.Admin Client
	            //////////////////////////////////////////
	            new Client
                {

                    ClientId =adminConfiguration.ClientId,
                    ClientName =adminConfiguration.ClientId,
                    ClientUri = adminConfiguration.IdentityAdminBaseUrl,

                    AllowedGrantTypes = GrantTypes.Hybrid,

                    ClientSecrets = new List<Secret>
                    {
                        new Secret(configuration[KeyVaultConsts.AdminUIClientSecret]?.ToSha256() ?? adminConfiguration.ClientSecret.ToSha256())
                    },

                    RedirectUris = { $"{adminConfiguration.IdentityAdminBaseUrl}/signin-oidc"},
                    FrontChannelLogoutUri = $"{adminConfiguration.IdentityAdminBaseUrl}/signout-oidc",
                    PostLogoutRedirectUris = { $"{adminConfiguration.IdentityAdminBaseUrl}/signout-callback-oidc"},
                    AllowedCorsOrigins = { adminConfiguration.IdentityAdminBaseUrl },

                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        "roles"
                    }
                },

                new Client
                {
                    ClientId = adminConfiguration.IdentityAdminApiSwaggerUIClientId,
                    ClientName = adminConfiguration.IdentityAdminApiSwaggerUIClientId,
                    
                    AllowedGrantTypes = GrantTypes.Implicit,

                    RedirectUris = new List<string>
                    {
                        adminConfiguration.IdentityAdminApiSwaggerUIRedirectUrl
                    },
                    AllowedScopes =
                    {
                        adminConfiguration.IdentityAdminApiScope
                    },
                    AllowAccessTokensViaBrowser = true
                }
            };

        }
    }
}

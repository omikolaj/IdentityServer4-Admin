﻿using ODMIdentity.STS.Identity.Configuration.Intefaces;

namespace ODMIdentity.STS.Identity.Configuration
{
    public class AdminConfiguration : IAdminConfiguration
    {
        public string IdentityAdminBaseUrl { get; set; } = "http://localhost:9000";
    }
}
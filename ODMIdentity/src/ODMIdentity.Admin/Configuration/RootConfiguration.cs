using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using ODMIdentity.Admin.Configuration.Interfaces;

namespace ODMIdentity.Admin.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {
        public IAdminConfiguration AdminConfiguration { get; set; }

        public RootConfiguration(IOptions<AdminConfiguration> adminConfiguration)
        {
            AdminConfiguration = adminConfiguration.Value;            
        }
    }
}

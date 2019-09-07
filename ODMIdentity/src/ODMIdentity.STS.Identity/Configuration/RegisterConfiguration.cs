using ODMIdentity.STS.Identity.Configuration.Intefaces;

namespace ODMIdentity.STS.Identity.Configuration
{
    public class RegisterConfiguration : IRegisterConfiguration
    {
        public bool Enabled { get; set; } = true;
    }
}

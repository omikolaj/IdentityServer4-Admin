namespace ODMIdentity.Admin.Api.Configuration.Constants
{
    public class AuthorizationConsts
    {
        public const string IdentityServerBaseUrl = "http://localhost:5000";
        public const string OidcSwaggerUIClientId = "ODMIdentityUIAdmin_api_swaggerui";
        public const string OidcApiName = "ODMIdentityUIAdmin_api";

        public const string AdministrationPolicy = "RequireAdministratorRole";
        public const string AdministrationRole = "OmniAdmin";
    }
}
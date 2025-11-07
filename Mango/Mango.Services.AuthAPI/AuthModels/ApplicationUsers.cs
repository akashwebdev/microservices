using Microsoft.AspNetCore.Identity;

namespace Mango.Services.AuthAPI.AuthModels
{
    public class ApplicationUsers : IdentityUser
    {
        public string Name { get; set; }
    }
}

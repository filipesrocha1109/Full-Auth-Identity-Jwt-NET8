using Microsoft.AspNetCore.Identity;

namespace FullAuthNET8.Infrastructure.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}

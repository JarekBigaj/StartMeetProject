using Microsoft.AspNetCore.Identity;

namespace StartMeet.Models
{
    public class AppUser : IdentityUser
    {
        [ProtectedPersonalData]
        public virtual string UserSecondName { get; set; }
    }
}
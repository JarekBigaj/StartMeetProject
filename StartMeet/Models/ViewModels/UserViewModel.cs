using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace StartMeet.Models.ViewModels
{
    public class CreateModel
    {
        
        [Required]
        public string Name{ get; set; }
        [Required]
        public string Email {get; set;}
        [Required]
        public string Password {get; set;}
        [Required]
        public Cities City { get; set; }
        [Required]
        public Months Month { get; set; }
        [Required]
        public string Day { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public Genders Gender { get; set; } 
    }

    public class LoginModel
    {
        [Required]
        [UIHint("email")]
        public string Email { get; set; }
        [Required]
        [UIHint("password")]
        public string Password { get; set; }
    }

    public class RoleEditModel
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<AppUser> Members { get; set; }
        public IEnumerable<AppUser> NonMembers { get; set; }
    }

    public class RoleModifactionModel
    {
        [Required]
        public string RoleName { get; set; }
        public string RoleId { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }
    }

    public class UsersPropertiesModel
    {
    }
}
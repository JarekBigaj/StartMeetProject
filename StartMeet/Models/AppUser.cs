using Microsoft.AspNetCore.Identity;

namespace StartMeet.Models
{
    public enum Cities
    {
        Empty,
        //Poland
        Warsaw, 
        //England
        London,
        //France
        Paris
    }


    public enum Months
    {
        January, February, March, April, May, June, July, August, September, October, November, December
    }

    public enum Genders
    {
        Male, Female, Other
    }
    public class AppUser : IdentityUser
    {
        public Cities City { get; set; }
        public Genders Gender { get; set; } 

        public string SecondName { get; set; }
        
    }
}
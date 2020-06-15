using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace StartMeet.Models
{
    public enum Cities
    {
        Empty,
        //England
        London,
        //France
        Paris,
        //Poland
        Warsaw
    }
    public enum Genders
    {
        Empty, Male, Female, Other
    }
    public enum Months
    {
        January, February, March, April, May, June, July, August, September, October, November, December
    }

    public class AppUser : IdentityUser
    {
        public Cities City { get; set; }
        public Genders Gender { get; set; }
        public Months Month { get; set; }

        public string Day { get; set; }
        public string Year { get; set; }

    }

}
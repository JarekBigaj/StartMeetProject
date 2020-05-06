using System.ComponentModel.DataAnnotations;

namespace StartMeet.Models.ViewModels
{
    public class CreateModel
    {
        [Required]
        public string Name{ get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required]
        public string Email {get; set;}
        [Required]
        public string Password {get; set;}
    }
}
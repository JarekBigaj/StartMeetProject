using System.Collections.Generic;

namespace StartMeet.Models.ViewModels
{
    public class MultipleAccountSettingsModel
    {
        public LoginModel SignInModel { get; set; }
        public CreateModel RegisterModel { get; set; } 
        public UsersPropertiesModel CurrentUserModel { get; set; }

    }
}

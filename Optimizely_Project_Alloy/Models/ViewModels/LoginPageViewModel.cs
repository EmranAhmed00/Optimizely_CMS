using Optimizely_Project_Alloy.Models.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Optimizely_Project_Alloy.Models.ViewModels
{
    public class LoginPageViewModel : PageViewModel<LoginPage>
    {
        public LoginFormPostbackData LoginData { get; set; } = new LoginFormPostbackData();

        public string Message { get; set; }

        public LoginPageViewModel(LoginPage currentPage)
            : base(currentPage)
        {

        }
    }

    public class LoginFormPostbackData
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace QuatesApp.PageModels
{
    public class WelcomePageModel
    {
        public Command SignInCommand { get; set; }

        public WelcomePageModel()
        {
            SignInCommand = new Command(SignIn);    
        }

        private void SignIn()
        {
          
        }
    }
}

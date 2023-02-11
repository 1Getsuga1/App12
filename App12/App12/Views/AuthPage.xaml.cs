using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App12.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthPage : ContentPage
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private async void authBtn_Clicked(object sender, EventArgs e)
        {
            if (user.Text == "admin" && password.Text == "123")
            {
                Navigation.InsertPageBefore(new StudentsListPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                DisplayAlert("Ошибка", "Логин или пароль неверны!", "Ок");
            }
        }

        
        
    }
}
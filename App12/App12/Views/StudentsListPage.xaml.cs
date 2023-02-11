using App12.Models;
using App12.ViewModels;
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
    public partial class StudentsListPage : ContentPage
    {
        public StudentsListPage()
        {
            Label labelTest = new Label
            {
                Text = "Italics",
                FontAttributes = FontAttributes.Italic
            };
            Label labelTest1 = new Label
            {
                Text = "Italics",
                FontAttributes = FontAttributes.Italic
            };
            Label labelTest2 = new Label
            {
                Text = "Italics",
                FontAttributes = FontAttributes.Italic
            };
            Label labelTest3 = new Label
            {
                Text = "Italics",
                FontAttributes = FontAttributes.Italic
            };
            InitializeComponent();
            BindingContext = new StudentsListViewModel() { Navigation = this.Navigation };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            StudentsListViewModel studentsListViewModel = new StudentsListViewModel();
            
        }
    }
}
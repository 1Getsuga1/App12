using App12.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App12.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentPage : ContentPage
    {
        public StudentViewModel ViewModel { get; private set; }
        public StudentPage(StudentViewModel vm)
        {
            InitializeComponent();
            Label testLabel = new Label
            {
                Text = "Italics",
                FontAttributes = FontAttributes.Italic
            };
            Label testLabe1 = new Label
            {
                Text = "Italics",
                FontAttributes = FontAttributes.Italic
            };
            Label testLabe2 = new Label
            {
                Text = "Italics",
                FontAttributes = FontAttributes.Italic
            };
            ViewModel = vm;
            this.BindingContext = ViewModel;
        }
    }
}
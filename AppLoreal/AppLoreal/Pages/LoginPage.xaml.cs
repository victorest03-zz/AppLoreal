using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AppLoreal.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLoreal.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
        }

        class LoginPageViewModel : INotifyPropertyChanged
        {
            public ICommand LoginCommand { get; set; }
            public ICommand NewUserCommand { get; set; }

            public LoginPageViewModel()
            {
                LoginCommand = new Command(Login);
                NewUserCommand = new Command(NewUser);
            }

            private void Login()
            {
                Device.BeginInvokeOnMainThread(() => Application.Current.MainPage = new HomePage());
            }

            private void NewUser()
            {
                Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new CreateUserPage()));
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
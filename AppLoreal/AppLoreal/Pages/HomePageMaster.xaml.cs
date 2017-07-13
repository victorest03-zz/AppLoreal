using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AppLoreal.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLoreal.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePageMaster : ContentPage
    {
        public ListView ListView;

        public HomePageMaster()
        {
            InitializeComponent();

            BindingContext = new HomePageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class HomePageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<HomePageMenuItem> MenuItems { get; set; }

            public HomePageMasterViewModel()
            {
                MenuItems = new ObservableCollection<HomePageMenuItem>(new[]
                {
                    new HomePageMenuItem { Id = 0, Title = "Inicio", IconUrl = "Home.png"},
                    new HomePageMenuItem { Id = 1, Title = "Perfil", IconUrl = "Profile.png" },
                    new HomePageMenuItem { Id = 2, Title = "Mis Cursos", IconUrl = "Courses.png" },
                    new HomePageMenuItem { Id = 3, Title = "Configuracion", IconUrl = "Settings.png" },
                    new HomePageMenuItem { Id = 4, Title = "Ayuda y Comentarios", IconUrl = "Help.png" }
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
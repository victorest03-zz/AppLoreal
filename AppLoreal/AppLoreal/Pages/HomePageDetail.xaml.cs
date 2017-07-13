using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AppLoreal.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLoreal.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePageDetail : ContentPage
    {
        public HomePageDetail()
        {
            InitializeComponent();

            BindingContext = new HomePageDetailViewModel();
            
        }

        class HomePageDetailViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<CourseModel> CursosItems { get; set; }

            public HomePageDetailViewModel()
            {
                CursosItems = new ObservableCollection<CourseModel>(new[]
                {
                    new CourseModel {Name = "Curso de Maquilla Facial", Brand = "Kerastase", Image = "kerastase.png",Price = 50.99,NroClases = 24, CupoMaximo = 50,CupoDisponible = 10},
                    new CourseModel {Name = "Curso de Faciales", Brand = "Lancome", Image = "kerastase.png",NroClases = 10, CupoMaximo = 25,CupoDisponible = 10},
                    new CourseModel {Name = "Curso de Peluqueria Artistico", Brand = "BioTherm", Image = "kerastase.png",Price = 149.99,NroClases = 24, CupoMaximo = 80,CupoDisponible = 10},
                    new CourseModel {Name = "Curso de Modelado Facial", Brand = "Diesel", Image = "kerastase.png",Price = 89.99,NroClases = 24, CupoMaximo = 50,CupoDisponible = 10},

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

        private void LsCursos_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return; // has been set to null, do not 'process' tapped event
            var itemselect = (CourseModel) e.SelectedItem;
            var master = Application.Current.MainPage as HomePage;
            if (master != null) master.Detail.Navigation.PushAsync(new CoursePage(itemselect));
        }
    }
}
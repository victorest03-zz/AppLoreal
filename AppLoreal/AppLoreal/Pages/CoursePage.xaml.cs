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
	public partial class CoursePage : ContentPage
	{
	    public CoursePage()
	    {
	        InitializeComponent();
	    }

        public CoursePage (CourseModel courseModel = null)
		{
			InitializeComponent ();
		    BindingContext = new CoursePageViewModel(courseModel);
        }

	    class CoursePageViewModel : INotifyPropertyChanged
	    {
	        public CourseModel CourseModel { get; set; }

	        public CoursePageViewModel(CourseModel courseModel)
	        {
	            CourseModel = courseModel;
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
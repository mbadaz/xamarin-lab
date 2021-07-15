using Xamarin.Forms;
using XamarinLab.WorkingWithImages;

namespace Udemy_Xamarin_Course
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new PhotoGalleryPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

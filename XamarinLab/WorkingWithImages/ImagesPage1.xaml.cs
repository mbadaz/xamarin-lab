using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Udemy_Xamarin_Course.Images
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagesPage1 : ContentPage
    {
        public ImagesPage1()
        {
            InitializeComponent();
            //LoadImageFromEmbeddedResource();
        }

        void LoadImageFromUrl()
        {
            myImage.Source = new UriImageSource { Uri = new Uri("http://2.bp.blogspot.com/-a1XAUOBgTqw/Tvfnq1RVdQI/AAAAAAAAAU4/HTZpkPnECBg/s1600/amazing+visata+wallpapers.jpg") };
        }

        void LoadImageFromEmbeddedResource() {
            myImage.Source = ImageSource.FromResource("XamarinLab.Images.background.jpg");
        }
    }
}
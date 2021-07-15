using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLab.WorkingWithImages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotoGalleryPage : ContentPage
    {
        public int PhotoNumber = 1;
        public PhotoGalleryPage()
        {
            InitializeComponent();
            BindingContext = this;
            OnImageNumberChanged();
        }

        public void OnPreviousClicked(object sender, EventArgs e)
        {
            PhotoNumber--;
            OnImageNumberChanged();
        }

        void OnNextClicked(object sender, EventArgs e)
        {
            PhotoNumber++;
            OnImageNumberChanged();
        }

        private void OnImageNumberChanged()
        {
            if (PhotoNumber == 1)
            {
                previousButton.IsVisible = false;
                return;
            } else if (PhotoNumber == 10)
            {
                nextButton.IsVisible = false;
            } else
            {
                previousButton.IsVisible = true;
                nextButton.IsVisible = true;
            }
            var imageUrl = string.Format("http://lorempixel.com/1920/1080/city/{0}", PhotoNumber);
            image.Source = new UriImageSource
            {
                Uri = new Uri(imageUrl),
                CachingEnabled = false
            };
        }
    }
}
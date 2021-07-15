using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Udemy_Xamarin_Course.XamlEssentials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayoutPage : ContentPage
    {
        public StackLayoutPage()
        {
            InitializeComponent();
            var layout = new StackLayout
            {
                Spacing = 40,
                Padding = new Thickness(0, 20, 0, 0),
                Orientation = StackOrientation.Vertical
            };

            layout.Children.Add(new Label { Text = "Label 1", HorizontalOptions = LayoutOptions.Center});
            layout.Children.Add(new Label { Text = "Lable 2", FontSize = 30, TextColor = Color.White });
            Content = layout;
        }
    }
}
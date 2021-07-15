using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinLab.MarkupExtensions
{   
    [ContentProperty("ResourceId")]
    public class EmbeddedImage : Xamarin.Forms.Xaml.IMarkupExtension
    {
        public string ResourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(ResourceId)) return null;
            return ImageSource.FromResource(ResourceId);
        }
    }
}

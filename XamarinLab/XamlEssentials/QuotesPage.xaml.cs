using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Udemy_Xamarin_Course.QuotesPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        private readonly List<string> Quotes;
        private int Counter;

        public QuotesPage()
        {
            InitializeComponent();
            Quotes = new List<string>();
            InitializeQuotes();

        }

        private void InitializeQuotes()
        {
            Quotes.Add("Love is blind");
            Quotes.Add("If you fall in love, do not blame gravity");
            Quotes.Add("When the cat is away, the mice play");
            Quotes.Add("Sometimes people think that they are thinking when " +
                "infact they are just rearranging their prejudices");
            quoteLabel.Text = Quotes.ElementAt(Counter);
        }

        public void OnNextButtonClicked(object sender, EventArgs e)
        {
           if(Counter == Quotes.Count - 1)
            {
                Counter = 0;
            }
           else
            {
                Counter++;
            }
            quoteLabel.Text = Quotes.ElementAt(Counter);
        }

        private void buttonNext_Clicked(object sender, EventArgs e)
        {

        }
    }
}
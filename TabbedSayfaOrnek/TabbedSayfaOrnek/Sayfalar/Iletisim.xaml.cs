using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedSayfaOrnek.Sayfalar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Iletisim : ContentPage
    {
        public Iletisim()
        {
            InitializeComponent();
        }

        private void yerDegisButton_Clicked(object sender, EventArgs e)
        {
            
        }

        private void bahsisHesapla_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BahsisHesaplama());
        }
    }
}
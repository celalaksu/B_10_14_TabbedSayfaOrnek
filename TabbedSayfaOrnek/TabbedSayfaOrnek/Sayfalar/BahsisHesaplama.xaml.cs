using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedSayfaOrnek
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BahsisHesaplama : ContentPage
    {
        public BahsisHesaplama()
        {
            InitializeComponent();
            
            
        }

        void AcikTema(object sender, EventArgs e)
        {
            Resources["metinRengi"] = Color.FromHex("#606060");
            Resources["arkaPlanRengi"] = Color.FromHex("#c0c0c0");
        }

        void KapaliTema(object sender, EventArgs e)
        {
            Resources["metinRengi"] = Color.FromHex("#c0c0c0");
            Resources["arkaPlanRengi"] = Color.FromHex("#606060");
        }
    }
}
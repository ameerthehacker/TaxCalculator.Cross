using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TaxCalculator.Cross
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            int amount;
            Int32.TryParse(txtAmount.Text, out amount);
            double result = amount * 0.3;

            lblResult.Text = result.ToString();
        }
    }
}

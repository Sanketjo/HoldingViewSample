using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HoldingViewSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            View.Holding += View_Holding;
        }

        private void View_Holding(object sender, EventArgs e)
        {
        }
    }
}

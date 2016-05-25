using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HoldingViewSample
{
    public class HoldingView : Grid
    {
        public event EventHandler Holding;

        public void FireHolding()
        {
            System.Threading.Volatile.Read(ref Holding)?.Invoke(this, EventArgs.Empty);
        }
    }
}

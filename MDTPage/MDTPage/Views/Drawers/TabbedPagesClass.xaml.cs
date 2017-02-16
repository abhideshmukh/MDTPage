using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MDTPage.Views.Drawers
{

    public partial class TabbedPagesClass : TabbedPage
    {
        
        public TabbedPagesClass()
        {
            InitializeComponent();
            var menuSelect = new DrawerPage();
            menuSelect.OnMenuSelect = (categoryPage) =>
            {
                
            };
           Children.Add(new Drawers.Page1());
           Children.Add(new Drawers.Page2());
           Children.Add(new Drawers.Page3());
           Children.Add(new Drawers.Page4());
            
                 
        }
    }
}

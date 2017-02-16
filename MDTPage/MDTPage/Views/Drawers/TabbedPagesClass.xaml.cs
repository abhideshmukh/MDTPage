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
            //List<Page> asd = new List<Page>();
            //asd.Add(new Page1());
            //asd.Add(new Page2());
            //asd.Add(new Page3());
            //asd.Add(new Page4());
            
            

            Children.Add(new Drawers.Page1());
            Children.Add(new Drawers.Page2());
            Children.Add(new Drawers.Page3());
            Children.Add(new Drawers.Page4());
            Children.Add(new Drawers.Page4());
            Children.Add(new Drawers.Page4());
            Children.Add(new Drawers.Page4());
            Children.Add(new Drawers.Page4());
            Children.Add(new Drawers.Page4());
            Children.Add(new Drawers.Page4());
            Children.Add(new Drawers.Page4());

            //CurrentPage = Children[1];

            //Device.BeginInvokeOnMainThread += async (s, e) =>
            // {
            //     await this.CurrentPage.SetValue = App.currentSelected;
            // };
            //var menuSelect = new DrawerPage();
            //menuSelect.OnMenuSelect = (categoryPage) =>
            //{
            //    this.CurrentPage
            //};





        }
    }
}

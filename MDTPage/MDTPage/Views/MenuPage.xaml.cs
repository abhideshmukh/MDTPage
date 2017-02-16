using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MDTPage.Views
{
    public partial class MenuPage : MasterDetailPage
    {
       
        
        public MenuPage()
        {
            InitializeComponent();
            
            var menuPage = new DrawerPage();

            menuPage.OnMenuSelect = (categoryPage) =>
           {
               
               Detail.Navigation.PushAsync(categoryPage);
               
               
               IsPresented = false;
           };


            Master = menuPage;
            //tabs.Children.Add(new Drawers.Page1());
            //tabs.Children.Add(new Drawers.Page2());
            //tabs.Children.Add(new Drawers.Page3());
            //tabs.Children.Add(new Drawers.Page4());

            var detailPage = new Drawers.TabbedPagesClass();
            Detail = detailPage;
            
        }
    }
}

         
            //Detail = new NavigationPage(new Drawers.Page1())
            //{

            //    BarBackgroundColor = Color.FromHex("#8999A6"),//your color here
            //    BarTextColor = Color.White
            //};
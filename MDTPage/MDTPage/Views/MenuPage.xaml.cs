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
        TabbedPage detailPage = new Drawers.TabbedPagesClass();

        public MenuPage()
        {
            InitializeComponent();
            var menuPage = new DrawerPage();
            menuPage.OnMenuSelect = (categoryPage) =>
           {
               if(categoryPage.Title =="Home Page")
               {
                   detailPage.CurrentPage = detailPage.Children[0];
               }
               if (categoryPage.Title == "Page2")
               {
                   detailPage.CurrentPage = detailPage.Children[1];
               }
               if (categoryPage.Title == "Page3")
               {
                   detailPage.CurrentPage = detailPage.Children[2];
               }

               //if you want to show the whole content page after selecting page in drawer than use below commented syntax 
               //Detail.Navigation.PushAsync(categoryPage);
               IsPresented = false;
           };
            Master = menuPage;
            Detail = detailPage;
        }
    }
}

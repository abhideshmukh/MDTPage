using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MDTPage.Views
{
    public partial class DrawerPage : ContentPage
    {



        public Action<ContentPage> OnMenuSelect
        {
            get;
            set;
        }
        public DrawerPage()

        {
            InitializeComponent();
            var categories = new List<Category>()
            {
                new Category("Page1",  () =>new Drawers.Page1()),
                new Category("Page2",  () =>new Drawers.Page2()),
                new Category("Page3",  () =>new Drawers.Page3()),
                new Category("Page4",  () =>new Drawers.Page4())

            };
            listed.BackgroundColor = Color.White;
            listed.ItemsSource = categories;

            listed.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                if (OnMenuSelect != null)
                {
                    var category = (Category)e.SelectedItem;
                    //if (category.Name == "Logout")
                    //{
                    //    App.Current.MainPage = new NavigationPage(new Login());
                    //}
                    var categoryPage = category.PageFn();
                    OnMenuSelect(categoryPage);
                }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WP8RestSL.Resources;
using WP8RestSL.ViewModelNameSpace;

namespace WP8RestSL
{
    public partial class MainPage : PhoneApplicationPage
    {
        private ViewModel vm;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            vm = new ViewModel();
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (!StateUtilities.IsLaunching && this.State.ContainsKey("Restaurants"))
            {
                // Old instance of the application
                // The user started the application from the Back button.

                vm = (ViewModel)this.State["Restaurants"];
                //MessageBox.Show("Got data from state");
            }
            else
            {
                // New instance of the application
                // The user started the application from the application list,
                // or there is no saved state available.

                vm.GetRestaurants();
                //MessageBox.Show("Did not get data from state");
            }


            // There are two different views, but only one view model.
            // So, use LINQ queries to populate the views.

            // If there is only one view, you could use the following code
            // to populate the view.
            RestaurantViewOnPage.DataContext = vm.Restaurants;
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            if (this.State.ContainsKey("Restaurants"))
            {
                this.State["Restaurants"] = vm;
            }
            else
            {
                this.State.Add("Restaurants", vm);
            }

            StateUtilities.IsLaunching = false;
        }

        private void AppBarSave_Click(object sender, EventArgs e)
        {
            vm.SaveRestaurants();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}
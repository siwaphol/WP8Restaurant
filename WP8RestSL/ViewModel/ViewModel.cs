using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WP8RestSL.Model;
using System.Collections.ObjectModel;
using System.IO.IsolatedStorage;
using System.Windows;

namespace WP8RestSL.ViewModelNameSpace
{
    class ViewModel
    {
        public ObservableCollection<Restaurant> Restaurants { get; set; }

        public void GetRestaurants()
        {
            if (IsolatedStorageSettings.ApplicationSettings.Count > 0)
            {
                GetSavedRestaurants();
            }
            else
            {
                GetDefaultRestaurants();
            }
        }

        public void GetDefaultRestaurants()
        {
            ObservableCollection<Restaurant> a = new ObservableCollection<Restaurant>();

            // Items to collect
            a.Add(new Restaurant() { Name = "Restaurant 1", Address = "123" });
            a.Add(new Restaurant() { Name = "Restaurant 2", Address = "Ite321m" });
            a.Add(new Restaurant() { Name = "Restaurant 3", Address = "Ite12m" });
            a.Add(new Restaurant() { Name = "Restaurant 4", Address = "It12em" });
            a.Add(new Restaurant() { Name = "Restaurant 5", Address = "It312em" });

            Restaurants = a;
            //MessageBox.Show("Got Restaurants from default");
        }


        public void GetSavedRestaurants()
        {
            ObservableCollection<Restaurant> a = new ObservableCollection<Restaurant>();

            foreach (Object o in IsolatedStorageSettings.ApplicationSettings.Values)
            {
                a.Add((Restaurant)o);
            }

            Restaurants = a;
            //MessageBox.Show("Got Restaurants from storage");
        }

        public void SaveRestaurants()
        {
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;

            foreach (Restaurant a in Restaurants)
            {
                if (settings.Contains(a.Name))
                {
                    settings[a.Name] = a;
                }
                else
                {
                    settings.Add(a.Name, a.GetCopy());
                }
            }

            settings.Save();
            MessageBox.Show("Finished saving Restaurants");
        }
    }
}

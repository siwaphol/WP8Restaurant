﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WP8Restaurant.Model;
using System.Collections.ObjectModel;
using System.IO;

namespace WP8Restaurant.ViewModel
{
    class ViewModel
    {
        public ObservableCollection<Restaurant> Restaurants { get; set; }

        //public void GetAccomplishments()
        //{
        //    if (IsolatedStorageSettings.ApplicationSettings.Count > 0)
        //    {
        //        GetSavedAccomplishments();
        //    }
        //    else
        //    {
        //        GetDefaultAccomplishments();
        //    }
        //}


        //public void GetDefaultAccomplishments()
        //{
        //    ObservableCollection<Accomplishment> a = new ObservableCollection<Accomplishment>();

        //    // Items to collect
        //    a.Add(new Accomplishment() { Name = "Potions", Type = "Item" });
        //    a.Add(new Accomplishment() { Name = "Coins", Type = "Item" });
        //    a.Add(new Accomplishment() { Name = "Hearts", Type = "Item" });
        //    a.Add(new Accomplishment() { Name = "Swords", Type = "Item" });
        //    a.Add(new Accomplishment() { Name = "Shields", Type = "Item" });

        //    // Levels to complete
        //    a.Add(new Accomplishment() { Name = "Level 1", Type = "Level" });
        //    a.Add(new Accomplishment() { Name = "Level 2", Type = "Level" });
        //    a.Add(new Accomplishment() { Name = "Level 3", Type = "Level" });

        //    Accomplishments = a;
        //    //MessageBox.Show("Got accomplishments from default");
        //}


        //public void GetSavedAccomplishments()
        //{
        //    ObservableCollection<Accomplishment> a = new ObservableCollection<Accomplishment>();

        //    foreach (Object o in IsolatedStorageSettings.ApplicationSettings.Values)
        //    {
        //        a.Add((Accomplishment)o);
        //    }

        //    Accomplishments = a;
        //    //MessageBox.Show("Got accomplishments from storage");
        //}
    }
}

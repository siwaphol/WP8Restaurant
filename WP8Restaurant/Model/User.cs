using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WP8Restaurant.Model
{
    public class User : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        private string _username;
        private string _password;
        private int _role;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                //RaisePropertyChanged("Count");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // Create a copy of an object to save.
        // If your object is databound, this copy is not databound.
        public User GetCopy()
        {
            User copy = (User)this.MemberwiseClone();
            return copy;
        }
    }
}

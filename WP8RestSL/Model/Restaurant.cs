using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace WP8RestSL.Model
{
    [DataContract]
    class Restaurant : INotifyPropertyChanged
    {
        [DataMember]
        public string Name { get; set; }
        //public string Address { get; set; }
        //public string Phone { get; set; }
        //public string Details { get; set; }

        //private string _profile_image;

        private string _address;
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                RaisePropertyChanged("Address");
            }
        }

        public Restaurant GetCopy()
        {
            Restaurant copy = (Restaurant)this.MemberwiseClone();
            return copy;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP8Restaurant.Model
{
    class Food
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public int Price { get; set; }

        private string _profile_image;
    }
}

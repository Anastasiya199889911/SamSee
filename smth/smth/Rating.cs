using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smth
{
    class Rating
    {
        private int Id { get; set; }
        private string Name { get; set; }
        public Rating(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Rating()
        {

        }
        public string GetName()
        {
            return Name;
        }
    }
}

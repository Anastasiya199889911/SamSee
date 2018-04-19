using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smth
{
    class Country
    {
        private int Id { get; set; }
        private string Name { get; set; }
        public Country(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Country()
        {

        }
        public string GetName()
        {
            return Name;
        }
    }
}

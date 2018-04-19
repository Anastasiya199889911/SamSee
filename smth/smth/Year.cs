using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smth
{
    class Year
    {
        private int Id { get; set; }
        private string Name { get; set; }
        public Year(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Year()
        {

        }
        public string GetName()
        {
            return Name;
        }
    }
}

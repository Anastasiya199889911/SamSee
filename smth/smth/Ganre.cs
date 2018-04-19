using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace smth
{
    class Ganre
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Way { get; set; }
        public Ganre(int id, string name, string way)
        {
            Id = id;
            Name = name;
            Way = way;
        }
        public Ganre()
        {

        }
        public string GetName()
        {
            return Name;
        }
    }
}

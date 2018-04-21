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
        private int Pages { get; set; }
        public Ganre(int id, string name, string way, int pages)
        {
            Id = id;
            Name = name;
            Way = way;
            Pages = pages;
        }
        public Ganre()
        {

        }
        public string GetName()
        {
            return Name;
        }
        public int GetPages()
        {
            return Pages;
        }
        public string GetWay()
        {
            return Way;
        }
    }
}

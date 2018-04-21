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
        private int Start { get; set; }
        private int End { get; set; }
        public Year(int id, string name,int start, int end)
        {
            Id = id;
            Name = name;
            Start = start;
            End = end;
        }
        public Year()
        {

        }
        public string GetName()
        {
            return Name;
        }
        public int GetStart()
        {
            return Start;
        }
        public int GetEnd()
        {
            return End;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem
{
    public class Discipline
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<int> ChapterIDs { get; set; }
        public Discipline()
        {
        }
        public Discipline(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

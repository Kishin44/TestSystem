using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem
{
    public class StudentRecord
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public StudentRecord()
        {
        }
        public StudentRecord(string name, string id)
        {
            Name = name;
            Id = id;
        }
    }
}

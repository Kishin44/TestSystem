using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem
{
    public class Student
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Memo { get; set; }

        public Student()
        {
        }
        public Student(string name, string id)
        {
            Name = name;
            Id = id;
        }
    }
}

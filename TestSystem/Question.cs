using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem
{
    public class Question
    {
        [ReadOnlyAttribute(true)]
        public int ID { get; set; }
        public string Text { get; set; }
        public string Answer { get; set; }
        public string Variant1 { get; set; }
        public string Variant2 { get; set; }
        public string Variant3 { get; set; }
        [ReadOnlyAttribute(true)]
        public int ChapterID { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}

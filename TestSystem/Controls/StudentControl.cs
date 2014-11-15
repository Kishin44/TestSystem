using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STSdb4.Database;

namespace TestSystem
{
    public partial class StudentControl : UserControl
    {
        ITable<int, StudentRecord> Students;

        public StudentControl()
        {
            InitializeComponent();
        }

        public void LoadStudents(ITable<int, StudentRecord> students)
        {
            Students = students;

            foreach (var item in students)
            {
                var temp = new ListViewItem(item.Value.Name);
                temp.Tag = item.Key;
                listView1.Items.Add(temp);
            }
        }

        private void StudentControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (Students.Count() != 0)
                index = (int)Students.Count();

            var rec = new StudentRecord(textBox1.Text, "sadad");
            Students[index] = rec;
            listView1.Items.Add(rec.Name);
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var selected = listView1.SelectedItems;
            if (selected.Count > 0)
                propertyGrid1.SelectedObject = Students[(int)listView1.SelectedItems[0].Tag];
        }
    }
}

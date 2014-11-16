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
    public partial class QuestionViewerControl : UserControl
    {
        public QuestionViewerControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewQuestionForm form = new AddNewQuestionForm();
            form.CreateNewQuestion();
            form.ShowDialog();
            
        }

        public void Reload(DatabaseContainer dbContainer)
        {
            LoadQuestions(dbContainer.Questions);
            LoadDisciplines(dbContainer.Disciplines);
        }

        private void LoadDisciplines(ITable<int, Discipline> table)
        {
            foreach(var kv in table)
            {
                var node = new TreeNode(kv.Value.Name);
                node.Tag = kv.Value;
                treeView1.Nodes.Add(new TreeNode());
            }
        }

        private void LoadQuestions(ITable<int, Question> table)
        {
            listBox1.Items.Clear();

            foreach (var kv in table)
                listBox1.Items.Add(kv.Value);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            newQuestionControl1.Question = ((Question)listBox1.SelectedItem);
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
           
        }

        private void addTopicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NameDialogForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                treeView1.Nodes.Add(new TreeNode(form.ChosenName));
                int count = (int)Program.DatabaseContainer.Disciplines.Count();
                Program.DatabaseContainer.Disciplines[count] = new Discipline(count, form.ChosenName);
                Program.DatabaseContainer.Commit();
            }
        }

        private void addThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NewChapterForm();
            form.LoadDisciplines(Program.DatabaseContainer.Disciplines);
            if (form.ShowDialog() == DialogResult.OK)
            {
                foreach (TreeNode node in treeView1.Nodes)
                {
                    if (form.DisciplineName == node.Text)
                    {
                        treeView1.BeginUpdate();
                        node.Nodes.Add(new TreeNode(form.ChapterName));
                        treeView1.EndUpdate();
                    }
                }
                    
            }
        }
    }
}

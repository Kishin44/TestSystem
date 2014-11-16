using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSystem
{
    public partial class TestGenerator : Form
    {
        public TestGenerator()
        {
            InitializeComponent();
            tabControl.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            EnterDialog(openFileDialog);
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void TestGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.DatabaseContainer != null)
            {
                Program.DatabaseContainer.Dispose();
                Program.DatabaseContainer = null;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string FileName = saveFileDialog.FileName;
            EnterDialog(saveFileDialog);
        }

        private void EnterDialog(FileDialog dialog)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var section = configuration.AppSettings.Settings["LastFile"];
            string dir;

            if (section == null)
            {
                configuration.AppSettings.Settings.Add("LastFile", @"C:\");
                configuration.Save();
                section = configuration.AppSettings.Settings["LastFile"];
            }

            dir = section.Value;

            dialog.InitialDirectory = Directory.GetParent(dir).FullName;
            dialog.Filter = "STS Files (*.stsdb)|*.stsdb";
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = dialog.FileName;

                Program.DatabaseContainer = new DatabaseContainer(FileName);
                this.Text = String.Format("TestGenerator [{0}]", FileName);

                configuration.AppSettings.Settings["LastFile"].Value = FileName;
                configuration.Save();
                StudentControl studentControl = new StudentControl();
                studentControl.LoadStudents(Program.DatabaseContainer.Students);
                studentControl.Visible = true;
                studentControl.Dock = DockStyle.Fill;
                tabPage1.Controls.Add(studentControl);

                QuestionViewerControl questoinsControl = new QuestionViewerControl();
                questoinsControl.Dock = DockStyle.Fill;
                studentControl.Visible = true;
                tabPage2.Controls.Add(questoinsControl);
                tabControl.Visible = true;
            }
        }
    }
}

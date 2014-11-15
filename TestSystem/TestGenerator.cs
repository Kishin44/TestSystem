using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSystem
{
    public partial class TestGenerator : Form
    {
        DatabaseContainer DatabaseContainer;

        public TestGenerator()
        {
            InitializeComponent();
            tabControl.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

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

            openFileDialog.InitialDirectory = dir;
            openFileDialog.Filter = "STS Files (*.stsdb)|*.stsdb|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                DatabaseContainer = new DatabaseContainer(FileName);
                this.Text = String.Format("TestGenerator [{0}]", FileName);

                configuration.AppSettings.Settings["LastFile"].Value = FileName;
                configuration.Save();
                StudentControl studentControl = new StudentControl();
                studentControl.LoadStudents(DatabaseContainer.StudentsTable);
                studentControl.Visible = true;
                studentControl.Dock = DockStyle.Fill;
                
                tabPage1.Controls.Add(studentControl);
                tabControl.Visible = true;

            }
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void TestGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatabaseContainer.Dispose();
        }
    }
}

namespace TestSystem
{
    partial class QuestionViewerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addTopicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newQuestionControl1 = new TestSystem.Controls.NewQuestionControl();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.CheckBoxes = true;
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.FullRowSelect = true;
            this.treeView1.Location = new System.Drawing.Point(3, 20);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(171, 355);
            this.treeView1.TabIndex = 0;
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(181, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(173, 355);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Disciplines :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Questions :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "New Question";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTopicToolStripMenuItem,
            this.addThemeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // addTopicToolStripMenuItem
            // 
            this.addTopicToolStripMenuItem.Name = "addTopicToolStripMenuItem";
            this.addTopicToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addTopicToolStripMenuItem.Text = "Add Discipline";
            this.addTopicToolStripMenuItem.Click += new System.EventHandler(this.addTopicToolStripMenuItem_Click);
            // 
            // addThemeToolStripMenuItem
            // 
            this.addThemeToolStripMenuItem.Name = "addThemeToolStripMenuItem";
            this.addThemeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addThemeToolStripMenuItem.Text = "Add Chapter";
            this.addThemeToolStripMenuItem.Click += new System.EventHandler(this.addThemeToolStripMenuItem_Click);
            // 
            // newQuestionControl1
            // 
            this.newQuestionControl1.Location = new System.Drawing.Point(360, 20);
            this.newQuestionControl1.Name = "newQuestionControl1";
            this.newQuestionControl1.Question = null;
            this.newQuestionControl1.Size = new System.Drawing.Size(304, 265);
            this.newQuestionControl1.TabIndex = 4;
            // 
            // QuestionViewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newQuestionControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "QuestionViewerControl";
            this.Size = new System.Drawing.Size(665, 378);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Controls.NewQuestionControl newQuestionControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addTopicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addThemeToolStripMenuItem;
    }
}

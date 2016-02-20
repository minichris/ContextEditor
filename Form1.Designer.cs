namespace ContextEditorCL
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.NewNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderToggle = new System.Windows.Forms.CheckBox();
            this.System32Box = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(15, 25);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(131, 199);
            this.listBox3.TabIndex = 0;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Global Context Menu Items";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 225);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NewNameBox
            // 
            this.NewNameBox.Location = new System.Drawing.Point(15, 230);
            this.NewNameBox.Name = "NewNameBox";
            this.NewNameBox.Size = new System.Drawing.Size(131, 20);
            this.NewNameBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Use \"%1\" to refer to the file that is being rightclicked on";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FolderToggle
            // 
            this.FolderToggle.AutoSize = true;
            this.FolderToggle.Location = new System.Drawing.Point(233, 260);
            this.FolderToggle.Name = "FolderToggle";
            this.FolderToggle.Size = new System.Drawing.Size(85, 17);
            this.FolderToggle.TabIndex = 8;
            this.FolderToggle.Text = "Folder Mode";
            this.FolderToggle.UseVisualStyleBackColor = true;
            this.FolderToggle.CheckedChanged += new System.EventHandler(this.FolderToggle_CheckedChanged);
            // 
            // System32Box
            // 
            this.System32Box.AutoSize = true;
            this.System32Box.Cursor = System.Windows.Forms.Cursors.No;
            this.System32Box.Enabled = false;
            this.System32Box.Location = new System.Drawing.Point(324, 260);
            this.System32Box.Name = "System32Box";
            this.System32Box.Size = new System.Drawing.Size(102, 17);
            this.System32Box.TabIndex = 9;
            this.System32Box.Text = "System32 Mode";
            this.System32Box.UseVisualStyleBackColor = true;
            this.System32Box.CheckedChanged += new System.EventHandler(this.System32Box_CheckedChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(563, 287);
            this.Controls.Add(this.System32Box);
            this.Controls.Add(this.FolderToggle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewNameBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Global File Context Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox NewNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox FolderToggle;
        private System.Windows.Forms.CheckBox System32Box;
    }
}
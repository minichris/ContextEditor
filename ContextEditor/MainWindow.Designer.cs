namespace ContextEditorCL
{
    partial class MainWindow
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
            this.MenuItemBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CodeBox = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.NewNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.System32Box = new System.Windows.Forms.CheckBox();
            this.ModeSwitchBox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.AddressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuItemBox
            // 
            this.MenuItemBox.FormattingEnabled = true;
            this.MenuItemBox.Location = new System.Drawing.Point(15, 25);
            this.MenuItemBox.Name = "MenuItemBox";
            this.MenuItemBox.Size = new System.Drawing.Size(131, 199);
            this.MenuItemBox.TabIndex = 0;
            this.MenuItemBox.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
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
            // CodeBox
            // 
            this.CodeBox.Location = new System.Drawing.Point(152, 25);
            this.CodeBox.Multiline = true;
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(399, 225);
            this.CodeBox.TabIndex = 2;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(476, 256);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(152, 256);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(15, 256);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
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
            // System32Box
            // 
            this.System32Box.AutoSize = true;
            this.System32Box.Cursor = System.Windows.Forms.Cursors.No;
            this.System32Box.Enabled = false;
            this.System32Box.Location = new System.Drawing.Point(368, 260);
            this.System32Box.Name = "System32Box";
            this.System32Box.Size = new System.Drawing.Size(102, 17);
            this.System32Box.TabIndex = 9;
            this.System32Box.Text = "System32 Mode";
            this.System32Box.UseVisualStyleBackColor = true;
            // 
            // ModeSwitchBox
            // 
            this.ModeSwitchBox.FormattingEnabled = true;
            this.ModeSwitchBox.Items.AddRange(new object[] {
            "*",
            "Folder"});
            this.ModeSwitchBox.Location = new System.Drawing.Point(233, 258);
            this.ModeSwitchBox.Name = "ModeSwitchBox";
            this.ModeSwitchBox.Size = new System.Drawing.Size(121, 21);
            this.ModeSwitchBox.TabIndex = 10;
            this.ModeSwitchBox.SelectedIndexChanged += new System.EventHandler(this.ModeSwitchBox_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddressLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 284);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(563, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AddressLabel
            // 
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(563, 306);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ModeSwitchBox);
            this.Controls.Add(this.System32Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewNameBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MenuItemBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Global File Context Editor";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox MenuItemBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodeBox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox NewNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox System32Box;
        private System.Windows.Forms.ComboBox ModeSwitchBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel AddressLabel;
    }
}
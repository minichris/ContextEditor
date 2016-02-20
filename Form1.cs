using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ContextEditorCL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox3.DataSource = Program.GetRegistryContent(Program.KeyAddressPrefix);
            comboBox1.Text = "*";
        }
        string SelectedItem;
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = listBox3.SelectedItem.ToString();
            string RegPath = Program.KeyAddressPrefix + SelectedItem;
            textBox1.Text = Program.GetRegistryString(RegPath + @"\command", "IsolatedCommand");
            if (Program.GetRegistryString(RegPath, "NoWorkingDirectory") == "") //If there is a "no working directory" key
            {
                System32Box.Checked = true; //check the box
            }
            else
            {
                System32Box.Checked = false; //uncheck the box
            }
            AddressLabel.Text = @"HKEY_CLASSES_ROOT\" + RegPath + @"\command";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.AddKey(SelectedItem, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.RemoveKey(SelectedItem);
            listBox3.DataSource = Program.GetRegistryContent(Program.KeyAddressPrefix);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.AddKey(NewNameBox.Text, "");
            listBox3.DataSource = Program.GetRegistryContent(Program.KeyAddressPrefix);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.SetEditMode(comboBox1.SelectedItem.ToString());
            listBox3.DataSource = Program.GetRegistryContent(Program.KeyAddressPrefix);
        }
    }
}

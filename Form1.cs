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
            string RegPath = @"*\shell";
            using (RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(RegPath))
            {
                List<string> MyList = new List<string>();
                foreach (string SubKey in registryKey.GetSubKeyNames())
                {
                    MyList.Add(SubKey);
                }
                listBox3.DataSource = MyList;
                registryKey.Close();
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox3.SelectedItem.ToString();
        }
    }
}

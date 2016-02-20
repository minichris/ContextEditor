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
        public static List<string> GetRegistryContent(string RegPath)
        {
            using (RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(RegPath))
            {
                List<string> MyList = new List<string>();
                foreach (string SubKey in registryKey.GetSubKeyNames())
                {
                    if (SubKey != "removeproperties")
                    {
                        MyList.Add(SubKey);
                    }
                }
                registryKey.Close();
                return MyList;
            }
        }

        public static string GetRegistryString(string RegPath, string ValueName)
        {     
            using (RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(RegPath))
            {
                if (registryKey != null)
                {
                    foreach (string RegValueName in registryKey.GetValueNames())
                    {
                        if (RegValueName == ValueName)
                        {
                            return registryKey.GetValue(RegValueName).ToString();
                        }
                    }
                    registryKey.Close();
                }
                else
                {
                    return null;
                }
                return null;
            }
        }

        public Form1()
        {
            InitializeComponent();
            listBox3.DataSource = GetRegistryContent(@"*\shell");
            
        }
        string SelectedItem;
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = listBox3.SelectedItem.ToString();
            string RegPath = @"*\shell\" + SelectedItem + @"\command";
            textBox1.Text = GetRegistryString(RegPath, "IsolatedCommand");
            Console.WriteLine((RegPath));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.AddKey(SelectedItem, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.RemoveKey(SelectedItem);
            listBox3.DataSource = GetRegistryContent(@"*\shell");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.AddKey(NewNameBox.Text, "");
            listBox3.DataSource = GetRegistryContent(@"*\shell");
        }
    }
}

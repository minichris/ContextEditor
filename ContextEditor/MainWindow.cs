using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ContextEditorCL
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            
            ModeSwitchBox.Text = "*";
            MenuItemBox.DataSource = GetRegData(Program.KeyAddressPrefix);
        }

        private List<string> GetRegData(string Address)
        {
            List<string> RegContent = Program.GetRegistryContent(Address);
            string[] HiddenItems = new string[] { "removeproperties", "explore", "open", "opennewprocess", "opennewwindow" };
            foreach (string Item in Program.GetRegistryContent(Program.KeyAddressPrefix))
            {
                Console.WriteLine(Item);
                if (HiddenItems.Contains(Item))
                {
                    RegContent.Remove(Item);
                }
            }

            return RegContent;
        }

        string SelectedItem;

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = MenuItemBox.SelectedItem.ToString();
            string RegPath = Program.KeyAddressPrefix + SelectedItem;
            CodeBox.Text = Program.GetRegistryString(RegPath + @"\command", "IsolatedCommand");
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

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Program.AddKey(SelectedItem, CodeBox.Text);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Program.RemoveKey(SelectedItem);
            MenuItemBox.DataSource = GetRegData(Program.KeyAddressPrefix);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Program.AddKey(NewNameBox.Text, "");
            MenuItemBox.DataSource = GetRegData(Program.KeyAddressPrefix);
        }

        private void ModeSwitchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.SetEditMode(ModeSwitchBox.SelectedItem.ToString());
            MenuItemBox.DataSource = GetRegData(Program.KeyAddressPrefix);
        }
    }
}

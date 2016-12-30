using System;
using System.Collections.Generic;
using Microsoft.Win32;
using System.Windows.Forms;

namespace ContextEditorCL
{
    class Program
    {
        public static string KeyAddressPrefix = @"*\shell\";

        public static void SetEditMode(string PrefixMode)
        {
            KeyAddressPrefix = PrefixMode + @"\shell\";
        }

        public static List<string> GetRegistryContent(string RegPath)
        {
            using (RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(RegPath))
            {
                List<string> MyList = new List<string>();
                foreach (string SubKey in registryKey.GetSubKeyNames())
                {
                    MyList.Add(SubKey);
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

        static int ViewKey(string key)
        {
            string RegPath = KeyAddressPrefix + key;
            using (RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(RegPath))
            {
                Console.WriteLine("Reading from: HKEY_CLASSES_ROOT\\{0}", RegPath);

                foreach (string RealValueName in registryKey.GetValueNames())
                {
                    string valueName = RealValueName;
                    if (RealValueName == "")
                    {
                        valueName = "(Default)";
                    }
                    Console.WriteLine("{0,-8}: {1}", valueName, registryKey.GetValue(RealValueName).ToString());
                }

                foreach (string SubKey in registryKey.GetSubKeyNames())
                {
                    ViewKey(key + "\\" + SubKey);
                }
                registryKey.Close();
                return registryKey.SubKeyCount;
            }
        }

        public static void AddKey(string keyname, string command)
        {
            string RegPath = KeyAddressPrefix + keyname;
            using (RegistryKey registryKey = Registry.ClassesRoot.CreateSubKey(RegPath))
            {
                Console.WriteLine("Writing to: HKEY_CLASSES_ROOT\\{0}", RegPath);
                registryKey.SetValue("", keyname);
                registryKey.SetValue("NoWorkingDirectory", "");
                registryKey.Close();
            }
            using (RegistryKey SubregistryKey = Registry.ClassesRoot.CreateSubKey(RegPath + "\\command"))
            {
                SubregistryKey.SetValue("", command);
                SubregistryKey.SetValue("IsolatedCommand", command);
                Console.WriteLine("Set command: {0}", command);
                SubregistryKey.Close();
            }
        }

        public static void RemoveKey(string keyname)
        {
            string RegPath = KeyAddressPrefix + keyname;
            Registry.ClassesRoot.DeleteSubKeyTree(RegPath);
        }

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}

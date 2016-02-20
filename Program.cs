using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace ContextEditorCL
{
    class Program
    {
        static int ViewKey(string key)
        {
            string RegPath = @"*\shell\" + key;
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
            string RegPath = @"*\shell\" + keyname;
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
            string RegPath = @"*\shell\" + keyname;
            Registry.ClassesRoot.DeleteSubKeyTree(RegPath);
        }

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //args = new string[3];
            //args[0] = "add";
            //args[1] = "ToWebM";
            //args[2] = AppDomain.CurrentDomain.BaseDirectory + "ffmpeg.exe -i \"%1\" -c:v libvpx -crf 10 -b:v 1M -c:a libvorbis \"%1\".webm";
            /*if (args.Length == 0)//if there no command line arguments
            {
                Console.WriteLine("First argument options:");
                Console.WriteLine("View");
                Console.WriteLine("Add");
                Console.WriteLine("Remove");
                Console.WriteLine("\nSecond argument is the key name.");
            }
            else
            {
                switch (args[0])
                {
                    case "add":
                        if (args.Length == 2)
                        {
                            Console.WriteLine("Missing commandline arguments...");
                        }
                        else
                        {
                            string CommandArgs = "";
                            for (int ar = 2; ar < args.Length; ++ar)
                            {
                                CommandArgs = CommandArgs + args[ar] + " ";
                            }
                            AddKey(args[1], CommandArgs);
                        }
                        break;
                    case "remove":
                        RemoveKey(args[1]);
                        break;
                    default:
                        ViewKey(args[1]);
                        break;
                }
            }
            Console.WriteLine("Done...");*/
            //Console.ReadLine();
        }
    }
}

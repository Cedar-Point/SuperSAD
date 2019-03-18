using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperWash
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.icon;
            EnumerateUsers();
        }

        private List<string> profileList = new List<string>();

        private void EnumerateUsers()
        {
            RegistryKey ProfileList = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\ProfileList", false);
            foreach(string profile in ProfileList.GetSubKeyNames())
            {
                object profilePath = ProfileList.OpenSubKey(profile, false).GetValue("ProfileImagePath");
                if (
                    profilePath != null &&
                    (string)profilePath != @"C:\WINDOWS\system32\config\systemprofile" &&
                    (string)profilePath != @"C:\WINDOWS\ServiceProfiles\LocalService" &&
                    (string)profilePath != @"C:\WINDOWS\ServiceProfiles\NetworkService"
                )
                {
                    string profileName = profilePath.ToString().Replace(@"C:\Users\", "");
                    profileList.Add(profilePath.ToString());
                    usersList.Items.Add(profileName);
                }
            }
        }

        private void washBtn_Click(object sender, EventArgs e)
        {
            DeleteDirectory(@"C:\Users\shelby.jankaasdf");
        }

        public static bool DeleteDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.EnumerateFiles(path).ToArray();
                if (files.Length != 0)
                {
                    foreach (string file in files)
                    {
                        try
                        {
                            File.Delete(file);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            Logger.Error(file + ": Failed to delete: Access Denied! (The file may be open or in use)");
                            return false;
                        }
                        catch (Exception e)
                        {
                            Logger.Error(file + ": " + e.Message);
                            return false;
                        }
                        Logger.Good(file + ": Deleted.");
                    }
                }
                string[] dirs = Directory.EnumerateDirectories(path).ToArray();
                if (dirs.Length != 0)
                {
                    foreach (string dir in dirs)
                    {
                        if (!DeleteDirectory(dir))
                        {
                            return false;
                        }
                    }
                }
                try
                {
                    Directory.Delete(path);
                }
                catch (Exception e)
                {
                    Logger.Error(path + ": " + e.Message);
                    return false;
                }
                Logger.Good(path + ": Deleted.");
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Logger {

        public static void Good(string message)
        {
            Console.WriteLine(message);
        }

        public static void Error(string message)
        {
            Console.WriteLine(message);
        }

    }

}

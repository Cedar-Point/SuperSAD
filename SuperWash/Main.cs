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
using System.Security.AccessControl;

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
            DeleteDirectory(@"C:\Users\camryn - Copy");
        }

        public static bool DeleteDirectory(string path)
        {
            if (Directory.Exists(path))
            {
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
                    DirectoryInfo directoryInfo = new DirectoryInfo(path);
                    directoryInfo.Attributes = FileAttributes.Normal;
                    foreach(FileInfo file in directoryInfo.GetFiles())
                    {
                        file.Attributes = FileAttributes.Normal;
                    }
                    Directory.Delete(path, true);
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(path + ": " + e.Message);
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SuperWash
{
    public partial class Main : Form
    {

        [DllImport("userenv.dll", CharSet = CharSet.Unicode, ExactSpelling = false, SetLastError = true)]
        public static extern bool DeleteProfile(string sidString, string profilePath, string computerName);
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.icon;
            EnumerateUsers();
        }
        private List<string> profileSidList = new List<string>();
        private List<string> profileNameList = new List<string>();
        private void EnumerateUsers()
        {
            usersList.Items.Clear();
            profileSidList.Clear();
            profileNameList.Clear();
            RegistryKey ProfileList = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\ProfileList", false);
            foreach(string profile in ProfileList.GetSubKeyNames())
            {
                RegistryKey profileReg = ProfileList.OpenSubKey(profile, false);
                object profilePath = profileReg.GetValue("ProfileImagePath");
                if (
                    profilePath != null &&
                    profilePath.ToString().ToLower() != @"c:\windows\system32\config\systemprofile" &&
                    profilePath.ToString().ToLower() != @"c:\windows\serviceprofiles\localservice" &&
                    profilePath.ToString().ToLower() != @"c:\windows\serviceprofiles\networkservice"
                )
                {
                    string profileName = profilePath.ToString().Replace(@"C:\Users\", "");
                    profileSidList.Add(profile);
                    profileNameList.Add(profileName);
                    usersList.Items.Add(profileName);
                }
            }
        }
        private async void washBtn_Click(object sender, EventArgs e)
        {
            washBtn.Enabled = false;
            usersList.Enabled = false;
            gifShadow.BringToFront();
            deletingGif.BringToFront();
            deletingGif.Enabled = true;
            List<int> indexList = new List<int>();
            foreach (int index in usersList.SelectedIndices)
            {
                indexList.Add(index);
            }
            foreach (int index in indexList)
            {
                usersList.SelectedItem = profileNameList[index];
                Text = "Deleting: " + profileNameList[index] + "... (SuperWash)";
                await DeleteSelectIndex(index);
                usersList.Items.Remove(profileNameList[index]);
            }
            EnumerateUsers();
            Text = "SuperWash";
            deletingGif.Enabled = false;
            gifShadow.SendToBack();
            deletingGif.SendToBack();
            usersList.Enabled = true;
            washBtn.Enabled = true;
        }
        private Task DeleteSelectIndex(int index)
        {
            return Task.Run(() =>
            {
                DeleteProfile(profileSidList[index], null, null);
            });
        }
    }
}

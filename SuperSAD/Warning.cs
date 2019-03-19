using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSAD
{
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
        }

        private void Warning_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.icon;
            logoBox.Image = Properties.Resources.icon.ToBitmap();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

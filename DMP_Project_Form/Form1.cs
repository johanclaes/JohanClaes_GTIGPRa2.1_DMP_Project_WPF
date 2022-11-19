using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMP_Project_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "user")
            {
                if (txtPassword.Text == "password")
                {
                    ToonPlaylist ToonPlaylistWindow = new ToonPlaylist();
                    ToonPlaylistWindow.ShowDialog();
                    this.Hide();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JohanClaes_GTIGPRa2._1_DMP_Project_WPF
{
    public partial class Geboortedatum : Form
    {
        public Geboortedatum()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtGeboortedatum.Text == "05/06/2001")
            {
                this.Close();
                ToonPlaylist ToonPlaylistWindow = new ToonPlaylist();
                ToonPlaylistWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Onbekende geboortedatum!");
            }
        }
    }
}

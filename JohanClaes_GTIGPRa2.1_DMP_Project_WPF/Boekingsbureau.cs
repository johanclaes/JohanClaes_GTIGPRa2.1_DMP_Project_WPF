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
    public partial class Boekingsbureau : Form
    {
        public Boekingsbureau()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBureauName.Text == "dollepret")
            {
                this.Close();
                ComedianToevoegen ComedianToevoegenWindow = new ComedianToevoegen();
                ComedianToevoegenWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Onbekend bureau!");
            }
        }
    }
}

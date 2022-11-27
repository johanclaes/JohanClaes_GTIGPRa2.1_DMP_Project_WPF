using JohanClaes_GTIGPRa2._1_DMP_Project_WPF;
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
    public partial class usernamePassword : Form
    {
        public usernamePassword()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "user")
            {
                if (txtPassword.Text == "password")
                {
                    this.Close();
                    EventToevoegen EventToevoegenWindow = new EventToevoegen();
                    EventToevoegenWindow.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Wrong password");
                }
            }
            else
            {
                MessageBox.Show("Onbekende username!");
            }
        }
    }
}

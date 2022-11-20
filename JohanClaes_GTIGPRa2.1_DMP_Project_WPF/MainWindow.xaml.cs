using DMP_Project_Form;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JohanClaes_GTIGPRa2._1_DMP_Project_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ZoekEvents_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void EventToevoegen_Click(object sender, RoutedEventArgs e)
        {
            var myForm = new usernamePassword();
            myForm.Show();
        }

        private void ToonPlaylist_Click(object sender, RoutedEventArgs e)
        {
            var myForm = new Geboortedatum();
            myForm.Show();
        }

        private void ComedianToevoegen_Click(object sender, RoutedEventArgs e)
        {
            var myForm = new Boekingsbureau();
            myForm.Show();
        }
    }
}

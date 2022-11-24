using DMP_Project_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JohanClaes_GTIGPRa2._1_DMP_Project_WPF
{
    /// <summary>
    /// Interaction logic for ZoekEvent.xaml
    /// </summary>
    public partial class ZoekEvent : Window
    {
        public ZoekEvent()
        {
            InitializeComponent();
        }

        List<Comedian> lijstcomedians = new List<Comedian>();
        List<string> stringlijstcomedians = new List<string>();
        List<string> provincies = new List<string>() { "antwerpen", "brabant" , "limburg" , "oost-vlaanderen" , "west-vlaanderen" };
        List<string> maanden = new List<string>() { "januari","februari","maart","april","mei","juni","juli","augustus","september","oktober","november","december" };

        private void BTNZoek_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            List<Comedian> lijstcomedians = new List<Comedian>();


            string sql = "SELECT * FROM Comedian";
            sql += " ORDER BY naam";

            // var parameters = new { @naam = naam };

            lijstcomedians = DatabaseOperations.OphalenComedians();

            

            
            cmbMaand.ItemsSource = maanden;

            
            cmbProvincie.ItemsSource = provincies;

            // dataComedians.ItemsSource = lijstcomedians;
            foreach (Comedian comedian1 in lijstcomedians)
            {
                stringlijstcomedians.Add(comedian1.voornaam + " " + comedian1.naam);
            }
            cmbComedian.ItemsSource = stringlijstcomedians;
        }    
    }
}

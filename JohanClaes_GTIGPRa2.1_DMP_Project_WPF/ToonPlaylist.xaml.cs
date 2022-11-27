using Dapper;
using DMP_Project_DAL;
using DMP_Project_Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for ToonPlaylist.xaml
    /// </summary>
    public partial class ToonPlaylist : Window
    {
        public ToonPlaylist()
        {
            InitializeComponent();
        }

        List<Comedian> lijstcomedians = new List<Comedian>();
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT * FROM Comedian";
            sql += " ORDER BY naam";

            // var parameters = new { @naam = naam };

            lijstcomedians = DatabaseOperations.OphalenComedians();
            
            dataComedians.ItemsSource = lijstcomedians;

            



            
        }
    }
}

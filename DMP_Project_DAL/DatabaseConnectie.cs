using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP_Project_DAL
{
    public class DatabaseConnectie: IDatabaseConnectie
    {
        public IDbConnection Connectie { get; set;  }

        public DatabaseConnectie()
        {
            Connecteren();
        }

        public void Connecteren()
        {
            try
            {
                Connectie = new SqlConnection("server=(localdb)\\mssqllocaldb,Database=Test;MultipleActiveResultSets=True");
            }
            catch (Exception ex)
            {

                throw new Exception("Er is probleem met SQL-connectie.");
            }           


        }

        public void Open()
        {
            if (true )
            {

            }
        }

        public void Close()
        { }
    }
}

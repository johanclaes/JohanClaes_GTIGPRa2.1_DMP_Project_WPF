using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP_Project_DAL
{
    public static class DatabaseOperations
    {
        private static DatabaseConnectie _db;

        private static void Start()
        {
            _db = new DatabaseConnectie();
            _db.Open();
        }

        public static List<Comedian> OphalenComedians()
        {
            Start();
            var result = _db.Connectie.Query<Comedian>("SELECT * FROM Comedy.Comedian;").ToList();
            _db.Close();

            return result;
        }
    }
}

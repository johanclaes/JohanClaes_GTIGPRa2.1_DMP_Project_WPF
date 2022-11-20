using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP_Project_DAL
{
    public interface IDatabaseConnectie
    {
        void Connecteren();
        IDbConnection Connectie ();

        void Open();

        void Close();
    }
}

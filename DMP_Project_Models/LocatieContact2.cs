using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP_Project_Models
{
    class LocatieContact2
    {
        public int Id { get; set; }

        public string naam { get; set; }
        public string voornaam { get; set; }
        public string loginName { get; set; }
        private string _loginPassword;

        public string loginPassword
        {
            get { return _loginPassword; }
            set { _loginPassword = value; }
        }
        public string telefoonNummer { get; set; }
        public int locatieId { get; set; }


    }
}

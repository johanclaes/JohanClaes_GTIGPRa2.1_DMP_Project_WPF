using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP_Project_Models
{
    public class Locatie2
    {
        public int Id { get; set; }
        public string naam { get; set; }
        public string adres { get; set; }
        public string gemeente { get; set; }

        public string provincie { get; set; }
        public string  gebouwType { get; set; }
    }
}

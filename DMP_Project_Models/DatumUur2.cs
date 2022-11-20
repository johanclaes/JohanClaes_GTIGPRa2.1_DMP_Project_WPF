using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP_Project_Models
{
    public class DatumUur2
    {
        public int Id { get; set; }
        public int eventId { get; set; }
        public DateTime datum { get; set; }
        public DateTime tijdstip { get; set; }
    }
}

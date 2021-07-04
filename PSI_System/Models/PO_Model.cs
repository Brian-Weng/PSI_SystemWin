using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_System.Models
{
    public class PO_Model
    {
        public string PID { get; set; }
        public int Items { get; set; }
        public int QTY { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal Total { get; set; }

        public DateTime CreateDate { get; set; }

        public string Creator { get; set; }

        public DateTime? ModifyDate { get; set; }

        public string Modifier { get; set; }

        public DateTime? DeleteDate { get; set; }

        public string Deleter { get; set; }
    }
}

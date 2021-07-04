using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_System.ViewModels
{
    public class PODetailViewModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int? Qty { get; set; }
        public decimal? Amount { get; set; }
    }
}

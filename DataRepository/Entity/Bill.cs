using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository.Entity
{
    public class Bill:InfoTrace
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public long Total { get; set; }
        public long TotalAfterTax { get; set; }
        public bool State { get; set; }
        public bool Payment { get; set; }
        public long VAT { get; set; }
             
        public virtual ICollection<BillDetail> Detail { get; set; }
        public virtual Outlet Outlet { get; set; }
    }
}

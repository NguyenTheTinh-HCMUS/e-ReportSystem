using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository.Entity
{
    public class BillDetail:InfoTrace
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public long Quanlity { get; set; }
        public long Price { get; set; }
        public long DisCount { get; set; }
        public virtual Product Product { get; set; }
        public virtual Bill Bill { get; set; }

        

    }
}

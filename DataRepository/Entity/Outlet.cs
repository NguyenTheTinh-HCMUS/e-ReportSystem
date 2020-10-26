using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository.Entity
{
    public class Outlet:InfoTrace
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }

    }
}

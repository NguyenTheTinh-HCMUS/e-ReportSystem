using DataRepository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class ReportModel
    {
        public long Total { get; set; }
        public IList<Detail> details = new List<Detail>();
        public class Detail
        {
            public int product_id { get; set; }
            public string product_name { get; set; }
            public long quanlity { get; set; }
            public long price { get; set; }
            public DateTime? date { get; set; }
        }

    }
}
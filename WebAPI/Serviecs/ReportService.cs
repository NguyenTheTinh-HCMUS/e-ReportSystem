using DataRepository.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebAPI.IServices;
using WebAPI.Models;
using static WebAPI.Models.ReportModel;

namespace WebAPI.Serviecs
{
    public class ReportService : IReportService
    {
        private readonly BillRepository _billRepository;
        #region Constructors
        public ReportService()
        {
            _billRepository = new BillRepository();
        }
        public ReportService(BillRepository billRepository)
        {
            _billRepository = billRepository;

        }


        #endregion
        public async Task<ReportModel> GetMonthReport()
        {
            var BillOnCurrentMonth = (await  _billRepository.Read()).Where(x => x.CreatedDate.Value.Month == DateTime.Now.Month);
            ReportModel rs = null;
            List<Detail> lst = new List<Detail> { };
            foreach (var item in BillOnCurrentMonth)
            {

                foreach (var item1 in item.Detail)
                {
                    lst.Add(new Detail { 
                    date=item.CreatedDate,
                    price=item1.Price,
                    product_id=item1.Product.Id,
                    product_name=item1.Product.Name,
                    quanlity=item1.Quanlity
                    });

                }

            }
            rs = new ReportModel {
                Total = BillOnCurrentMonth.Sum(x => x.Total),
                details=lst
            };
            return rs;
        
        }

    }
}
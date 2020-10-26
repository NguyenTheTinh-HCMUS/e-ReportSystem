using DataRepository.Entity;
using DataRepository.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPI.Models;
using WebAPI.Serviecs;

namespace WebAPI.Controllers
{
    public class ReportController : ApiController
    {
        private readonly ReportService _reportSevice;
        #region Constructors
        public ReportController()
        {
            _reportSevice = new ReportService();
        }
        public ReportController(ReportService reportService)
        {
            _reportSevice = reportService;
        }

        #endregion





        // GET: api/Report
        public async Task<ReportModel> Get()
        {
            return await _reportSevice.GetMonthReport();
            
        }

      


        // GET: api/Report/5

        public string Get(int id)
        {
            return "value";
        }
      

        // POST: api/Report
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Report/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Report/5
        public void Delete(int id)
        {
        }
    }
}

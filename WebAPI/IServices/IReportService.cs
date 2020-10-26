using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebAPI.Models;

namespace WebAPI.IServices
{
    public interface IReportService
    {
        Task<ReportModel> GetMonthReport();
    }
}
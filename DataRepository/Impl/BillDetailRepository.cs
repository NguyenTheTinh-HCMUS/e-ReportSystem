using DataRepository.Context;
using DataRepository.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository.Impl
{
    public class BillDetailRepository : IRepository<BillDetail>
    {
        private DataContext context;
        #region Constructors 
        public BillDetailRepository(DataContext context)
        {
            this.context = context;
        }

        public BillDetailRepository()
        {
            context = new DataContext();
        }
        #endregion
        public async Task Create(BillDetail t)
        {
            context.BillDetails.Add(t);
            await  context.SaveChangesAsync();

        }

        public async Task<int> Delete(BillDetail t)
        {
            context.BillDetails.Remove(t);
            return await context.SaveChangesAsync();
        }

        public async Task<IList<BillDetail>> Read()
        {
            return await context.BillDetails.ToListAsync();
        }

        public async Task<int> Update(BillDetail t)
        {
            context.Entry(t).State = EntityState.Modified;
            return await context.SaveChangesAsync();
        }
    }
}

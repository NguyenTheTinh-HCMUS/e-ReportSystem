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
    public class BillRepository : IRepository<Bill>
    {
        private DataContext context;
        #region Constructors 
        public BillRepository(DataContext context)
        {
            this.context = context;
        }

        public BillRepository()
        {
            context = new DataContext();
        }
        #endregion
        public async Task  Create(Bill t)
        {
             context.Bills.Add(t);
            await context.SaveChangesAsync();
        }

        public async Task<int> Delete(Bill t)
        {
            context.Bills.Remove(t);
            return await context.SaveChangesAsync();
        }

        public async Task<IList<Bill>> Read()
        {
            return await context.Bills.Include(x=>x.Detail.Select(y=>y.Product)).ToListAsync();
        }

        public async Task<int> Update(Bill t)
        {
            context.Entry(t).State = EntityState.Modified;
            return await context.SaveChangesAsync();
        }
    }
}

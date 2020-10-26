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
    public class OutletRepository : IRepository<Outlet>
    {
        private DataContext context;
        #region Constructors 
        public OutletRepository(DataContext context)
        {
            this.context = context;
        }

        public OutletRepository()
        {
            context = new DataContext();
        }
        #endregion
        public async Task Create(Outlet t)
        {
            context.Outlets.Add(t);
            await context.SaveChangesAsync();
        }

        public async Task<int> Delete(Outlet t)
        {
            context.Outlets.Remove(t);
           
            return await context.SaveChangesAsync();
        }

        public async Task<IList<Outlet>> Read()
        {
            return await context.Outlets.ToListAsync();
        }

        public async Task<int> Update(Outlet t)
        {
            context.Entry(t).State = System.Data.Entity.EntityState.Modified;
            return await context.SaveChangesAsync();

        }
    }
}

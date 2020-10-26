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
    public class ProductRepository : IRepository<Product>
    {
        private DataContext context;

        #region Constructors 
        public ProductRepository(DataContext context)
        {
            this.context = context;
        }

        public ProductRepository()
        {
            context = new DataContext();
        }
        #endregion
        public async Task Create(Product t)
        {
            context.Products.Add(t);
            await context.SaveChangesAsync();
        }

        public async Task<int> Delete(Product t)
        {
            context.Products.Remove(t);
            return await context.SaveChangesAsync();
        }

        public async Task<IList<Product>> Read()
        {
           return await context.Products.ToListAsync();
        }

        public async Task<int> Update(Product t)
        {
            context.Entry(t).State = EntityState.Modified;
            return await context.SaveChangesAsync();
        }
    }
}

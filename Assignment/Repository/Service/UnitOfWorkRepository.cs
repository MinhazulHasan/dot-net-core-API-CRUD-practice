using Assignment.Controllers;
using Assignment.Model;
using Assignment.Repository.Interface;

namespace Assignment.Repository.Service
{
    public class UnitOfWorkRepository : IUnitOfWork
    {
        public IProductRepository productRepository { get; private set; }

        private readonly ApplicationDBContext _dbContext;
        public UnitOfWorkRepository(ApplicationDBContext dbContext)
        {
            this._dbContext = dbContext;
            productRepository = new ProductRepository(this._dbContext);
        }

        public async Task CompleteAsync()
        {
            await this._dbContext.SaveChangesAsync();
        }
    }
}

using Assignment.Repository.Interface;

namespace Assignment.Controllers
{
    public interface IUnitOfWork
    {
        IProductRepository productRepository { get; }

        Task CompleteAsync();
    }
}

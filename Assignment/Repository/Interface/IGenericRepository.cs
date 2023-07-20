namespace Assignment.Repository.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllEntity();
        Task<T> GetEntity(int id);
        Task<bool> AddEntity(T entity);
        Task<bool> UpdateEntity(T entity);
        Task<bool> DeleteEntity(int id);
    }
}

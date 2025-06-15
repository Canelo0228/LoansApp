namespace LoansApp.Core.Application.Interfaces.Services
{
    public interface IGenericService<SaveEntity, ViewEntity, Entity>
        where SaveEntity : class
        where ViewEntity : class
        where Entity : class
    {
        Task AddAsync(SaveEntity saveEntity);
        Task UpdateAsync(SaveEntity saveEntity, int id);
        Task DeleteAsync(int id);
        Task<List<ViewEntity>> GetAllAsync();
        Task<ViewEntity> GetByIdAsync(int id);
    }
}

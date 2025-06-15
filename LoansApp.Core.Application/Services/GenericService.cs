using AutoMapper;
using LoansApp.Core.Application.Interfaces.Repositories;
using LoansApp.Core.Application.Interfaces.Services;

namespace LoansApp.Core.Application.Services
{
    public class GenericService<SaveEntity, ViewEntity, Entity> : IGenericService<SaveEntity, ViewEntity, Entity>
        where SaveEntity : class
        where ViewEntity : class
        where Entity : class
    {
        private readonly IGenericRepository<Entity> _repository;
        private readonly IMapper _mapper;

        public GenericService(IGenericRepository<Entity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual async Task AddAsync(SaveEntity saveEntity)
        {
            Entity entity = _mapper.Map<Entity>(saveEntity);
            await _repository.AddAsync(entity);
        }

        public virtual async Task UpdateAsync(SaveEntity saveEntity, int id)
        {
            Entity entity = _mapper.Map<Entity>(saveEntity);
            await _repository.UpdateAsync(entity, id);
        }

        public virtual async Task DeleteAsync(int id)
        {
            Entity entity = await _repository.GetByIdAsync(id);
            await _repository.DeleteAsync(entity);
        }

        public virtual async Task<List<ViewEntity>> GetAllAsync()
        {
            var entityList = await _repository.GetAllAsync();
            return _mapper.Map<List<ViewEntity>>(entityList); ;
        }

        public virtual async Task<ViewEntity> GetByIdAsync(int id)
        {
            Entity entity = await _repository.GetByIdAsync(id);
            ViewEntity viewEntity = _mapper.Map<ViewEntity>(entity);
            return viewEntity;
        }
    }
}

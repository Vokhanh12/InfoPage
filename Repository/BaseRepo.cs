namespace MyApplication.Repository
{
    public interface IBaseRepository<TEntity, TKey>
    {
        TEntity GetById(TKey id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }

}
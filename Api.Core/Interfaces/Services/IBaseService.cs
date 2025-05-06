namespace Api.Core.Interfaces.Services;

public interface IBaseService<T>
{
    Task<T?> GetById(Guid id);
    Task<IReadOnlyList<T>> GetAll();
    Task Add(T entity);
    Task Update(T entity);
    Task Delete(T entity);
}
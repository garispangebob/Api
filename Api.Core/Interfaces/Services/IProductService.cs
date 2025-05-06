using Api.Core.Entities;

namespace Api.Core.Interfaces.Services;

public interface IProductService : IBaseService<Product>
{
    Task<IReadOnlyList<Product>> GetProductsByUserAsync(User user);
    Task<IReadOnlyList<DraftProduct>> GetDraftProductsByUserAsync(User user);
    Task<IReadOnlyList<MarkingProduct>> GetMarkingProductsByUserAsync(User user);
    Task<IReadOnlyList<HardAlcoProduct>> GetHardAlcoProductsByUserAsync(User user);
}
using BBEngineGRPC.Protos;

namespace BBEngineGRPC.Repositories.Interfaces
{
    public interface IProducts
    {
        Task<ProductListItem> GetAllProduct(ProductRequestEmpty reqEmpty);
        Task<Model.Product> GetProductById(int id);
        Task<bool> Create(CreateProductRequest CreateRequest);
        Task<bool> Update(UpdateProductRequest UpdateRequest);
        Task<bool> Delete(DeleteProductRequest DeleteRequest);
    }
}

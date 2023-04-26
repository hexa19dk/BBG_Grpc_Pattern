using BBEngineGRPC.Protos;

namespace BBEngineGRPC.Usecase.Interfaces
{
    public interface IProductUsecase
    {
        Task<ProductListItem> GetAll(ProductRequestEmpty reqEmpty);
        Task<ProductListItem> GetById(ProductRequest reqId);
        Task<ResponseMessage> Create(CreateProductRequest createRequest);
        Task<ResponseMessage> Update(UpdateProductRequest updateRequest);
        Task<ResponseMessage> Delete(DeleteProductRequest deleteRequest);
    }
}

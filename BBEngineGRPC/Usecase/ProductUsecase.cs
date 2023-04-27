using BBEngineGRPC.Protos;
using BBEngineGRPC.Repositories.Interfaces;
using BBEngineGRPC.Usecase.Interfaces;
using Grpc.Core;

namespace BBEngineGRPC.Usecase
{
    public class ProductUsecase : IProductUsecase
    {
        private readonly ILogger<ProductUsecase> _logger;
        private IProductRepository _productRepo;

        public ProductUsecase(ILogger<ProductUsecase> logger, IProductRepository productRepo)
        {
            _logger = logger;
            _productRepo = productRepo;
        }

        async Task<ProductListItem> IProductUsecase.GetAll(ProductRequestEmpty reqEmpty)
        {
            return await _productRepo.Products().GetAllProduct(reqEmpty);
        }

        async Task<ProductList> IProductUsecase.GetById(ProductRequest reqId)
        {
            var data = await _productRepo.Products().GetProductById(reqId);
            return new ProductList
            {
                Id = data.Id,
                Name = data.Name,
                Stock = data.Stock,
                Price = data.Price,
                Description = data.Description
            };
        }

        async Task<ResponseMessage> IProductUsecase.Create(CreateProductRequest createRequest)
        {
            var result = await _productRepo.Products().Create(createRequest);
            if(result)
            {
                return new ResponseMessage
                {
                    Status = "Ok",
                    Message = "Data created successfully",
                    Code = 200
                };
            }

            throw new RpcException(new Status(StatusCode.Internal, "Failed to craete new product"));
        }

        async Task<ResponseMessage> IProductUsecase.Update(UpdateProductRequest updateRequest)
        {
            var result = await _productRepo.Products().Update(updateRequest);
            if (result)
            {
                return new ResponseMessage
                {
                    Status = "Ok",
                    Message = "Data updated successfully",
                    Code = 200
                };
            }

            throw new RpcException(new Status(StatusCode.Internal, "Failed to update data"));
        }

        async Task<ResponseMessage> IProductUsecase.Delete(DeleteProductRequest deleteRequest)
        {
            var result = await _productRepo.Products().Delete(deleteRequest);
            if (result)
            {
                return new ResponseMessage
                {
                    Status = "Ok",
                    Message = "Data deleted successfully",
                    Code = 200
                };
            }

            throw new RpcException(new Status(StatusCode.Internal, "Failed to delete data"));
        }        
    }
}

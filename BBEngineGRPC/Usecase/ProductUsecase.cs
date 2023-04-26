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

        Task<ProductListItem> IProductUsecase.GetById(ProductRequest reqId)
        {
            throw new NotImplementedException();
        }

        async Task<ResponseMessage> IProductUsecase.Create(CreateProductRequest createRequest)
        {
            var result = await _productRepo.Products().Create(createRequest);
            if(result)
            {
                return new ResponseMessage
                {
                    Status = "Ok",
                    Message = "Data Successfully created",
                    Code = 200
                };
            }

            throw new RpcException(new Status(StatusCode.Internal, "Failed to craete new product"));
        }

        Task<ResponseMessage> IProductUsecase.Delete(DeleteProductRequest deleteRequest)
        {
            throw new NotImplementedException();
        }

        Task<ResponseMessage> IProductUsecase.Update(UpdateProductRequest updateRequest)
        {
            throw new NotImplementedException();
        }
    }
}

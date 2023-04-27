using BBEngineGRPC.Protos;
using BBEngineGRPC.Usecase.Interfaces;
using Grpc.Core;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace BBEngineGRPC.Services
{
    public class ProductService : Protos.Product.ProductBase
    {
        private readonly ILogger<ProductService> _logger;
        private readonly IProductUsecase _productUsecase;
        public ProductService(ILogger<ProductService> logger, IProductUsecase productUsecase) 
        { 
            _logger = logger;
            _productUsecase = productUsecase;
        }

        public override async Task<ProductListItem> GetAllProduct(ProductRequestEmpty request, ServerCallContext context)
        {
            return await _productUsecase.GetAll(request);
        }

        public override async Task<ProductList> GetProductById(ProductRequest reqId, ServerCallContext context)
        {
            return await _productUsecase.GetById(reqId);
        }

        public override async Task<ResponseMessage> CreateProduct(CreateProductRequest request, ServerCallContext context)
        {
            return await _productUsecase.Create(request);
        }

        public override async Task<ResponseMessage> UpdateProduct(UpdateProductRequest request, ServerCallContext context)
        {
            return await _productUsecase.Update(request);
        }

        public override async Task<ResponseMessage> DeleteProduct(DeleteProductRequest request, ServerCallContext context)
        {
            return await _productUsecase.Delete(request);
        }
    }
}

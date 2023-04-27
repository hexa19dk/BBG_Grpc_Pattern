using BBEngineGRPC.Config;
using BBEngineGRPC.Protos;
using BBEngineGRPC.Repositories.Interfaces;
using BBEngineGRPC.Services;
using Dapper;
using Google.Api;
using Grpc.Core;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BBEngineGRPC.Repositories.Mysql
{
    public class ProductDb : IProducts
    {
        private readonly DataContext _ctx;
        private readonly ILogger<ProductService> _logger;
        public ProductDb(DataContext ctx, ILogger<ProductService> logger) 
        {
            _ctx = ctx;
            _logger = logger;
        }

        public async Task<ProductListItem> GetAllProduct(ProductRequestEmpty reqEmpty)
        {
            ProductListItem item = new ProductListItem();
            var result = await _ctx.Connection().QueryAsync<ProductList>("SELECT * FROM Product");
            item.Items.Add(result);

            return item;
        }

        public async Task<ProductList> GetProductById(ProductRequest reqId)
        {
            try
            {
                var query = "SELECT * FROM Product WHERE Id = " + reqId.ProductId;
                var result = await _ctx.Connection().QueryFirstOrDefaultAsync<ProductList>(query);

                return result;
            }
            catch (Exception ex)
            {
                throw new RpcException(new Status(StatusCode.Internal, "Failed to get product data"));
            }
        }
        
        public async Task<bool> Create(CreateProductRequest request)
        {
            try
            {
                var result = await _ctx.Connection().ExecuteAsync(
                "INSERT INTO Product(Name, Stock, Price, Description) VALUES(@Name, @Stock, @Price, @Description)",
                new
                {
                    Name = request.Name,
                    Stock = request.Stock,
                    Price = request.Price,
                    Description = request.Description
                });

                return result > 0;
            }
            catch(Exception ex)
            {
                return false;
            }            
        }

        public async Task<bool> Update(UpdateProductRequest updtReq)
        {
            try
            {
                var query = "UPDATE Product SET Name=@Name, Stock=@Stock, Price=@Price, Description=@Description WHERE Id=@Id";
                var result = await _ctx.Connection().ExecuteAsync(query, new
                {
                    Id = updtReq.Id,
                    Name = updtReq.Name,
                    Stock = updtReq.Stock,
                    Price = updtReq.Price,
                    Description = updtReq.Description
                });

                return result > 0;
            }
            catch(Exception ex)
            {
                return false;
            }            
        }
        
        public async Task<bool> Delete(DeleteProductRequest delReq)
        {
            var query = "DELETE FROM Product WHERE Id=" + delReq.ProductId;
            var result = await _ctx.Connection().ExecuteAsync(query, new { Id = delReq.ProductId });

            return result > 0;
        }
    }
}

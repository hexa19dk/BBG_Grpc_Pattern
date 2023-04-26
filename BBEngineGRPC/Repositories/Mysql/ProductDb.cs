using BBEngineGRPC.Config;
using BBEngineGRPC.Protos;
using BBEngineGRPC.Repositories.Interfaces;
using Dapper;

namespace BBEngineGRPC.Repositories.Mysql
{
    public class ProductDb : IProducts
    {
        private readonly DataContext _ctx;
        public ProductDb(DataContext ctx) 
        {
            _ctx = ctx;
        }

        public async Task<ProductListItem> GetAllProduct(ProductRequestEmpty reqEmpty)
        {
            ProductListItem item = new ProductListItem();
            var result = await _ctx.Connection().QueryAsync<ProductList>("SELECT * FROM Product");
            item.Items.Add(result);

            return item;
        }

        public Task<Model.Product> GetProductById(int id)
        {
            throw new NotImplementedException();
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

        public Task<bool> Update(UpdateProductRequest UpdateRequest)
        {
            throw new NotImplementedException();
        }
        
        public Task<bool> Delete(DeleteProductRequest DeleteRequest)
        {
            throw new NotImplementedException();
        }
    }
}

using BBEngineGRPC.Repositories.Interfaces;

namespace BBEngineGRPC.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IProducts _product;
        public ProductRepository(IProducts product) 
        {
            _product = product;
        }

        public IProducts Products()
        {
            return _product;
        }
    }
}

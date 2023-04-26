using BBEngineGRPC.Model;

namespace BBEngineGRPC.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IProducts Products();
    }

    public delegate IProductRepository ProductServiceSolver(ServiceType serviceType);
}

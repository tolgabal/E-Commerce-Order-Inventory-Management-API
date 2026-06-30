namespace ECommerceOrder.Core.Repositories;

public interface IUnitOfWork
{
    Task CommitAsync();
}
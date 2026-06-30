using System.Diagnostics.CodeAnalysis;
using ECommerceOrder.Core.Repositories;
using ECommerceOrder.Infrastructure.Context;

namespace ECommerceOrder.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }
}
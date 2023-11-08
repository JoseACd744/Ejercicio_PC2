using Ejercicio_PC2.Shared.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio_PC2.Shared.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly DbContext _context;

    public UnitOfWork(DbContext context)
    {
        _context = context;
    }

    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
       
}
using Microsoft.EntityFrameworkCore;

namespace Ejercicio_PC2.Shared.Infrastructure.Repositories;

public class BaseRepository
{
    protected readonly DbContext _context;

    public BaseRepository(DbContext context)
    {
        _context = context;
    }
}
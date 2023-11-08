namespace Ejercicio_PC2.Shared.Domain.Repository;

public interface IUnitOfWork
{
    Task CompleteAsync();
}
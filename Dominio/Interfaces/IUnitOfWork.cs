

namespace Dominio.Interfaces;

public interface IUnitOfWork
{
    IRolRepository Roles { get; }
    IUserRepository Users { get; }
    Task<int> SaveAsync();
}

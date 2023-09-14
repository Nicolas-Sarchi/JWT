using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repository;

public class RolRepository : GenericRepository<Rol>, IRolRepository
{
    private readonly JwtContext _context;

    public RolRepository(JwtContext context) : base(context)
    {
        _context = context;
    }
}
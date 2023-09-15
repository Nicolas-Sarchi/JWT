using System.Linq.Expressions;
using Dominio.Interfaces;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;
namespace Aplicacion.Repository
{
    public class MarcaRepository : GenericRepository<Marca>, IMarca
    {
        private readonly JwtContext _context;
        public MarcaRepository(JwtContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Marca>> GetAllAsync()
        {
            return await _context.Marcas.ToListAsync();
        }
    }
}
using System.Linq.Expressions;
using Dominio.Interfaces;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository
{
    public class CategoriaRepository : GenericRepository<Categoria>, ICategoria
    {
        private readonly JwtContext _context;
        public CategoriaRepository(JwtContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Categoria>> GetAllAsync()
        {
            return await _context.Categorias.ToListAsync();
        }
    }
}
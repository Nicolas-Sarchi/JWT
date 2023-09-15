using Dominio.Entities;
namespace Dominio.Interfaces;

public interface IProducto : IGenericRepository<Producto>
{
    Task<IEnumerable<Producto>> GetProductosMasCaros(int cantidad);
}
using System.ComponentModel.DataAnnotations;

namespace API.Dtos;

public class ProductoAddUpdateDto
{
    public int Id { get; set;}
    [Required(ErrorMessage = "El Nombre Del producto Es requerido")]

    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public DateTime FechaCreacion { get; set; }
    public int IdMarcaFk { get; set; }
    public int IdCategoriaFk { get; set; }
}

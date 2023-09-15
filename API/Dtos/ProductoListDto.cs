namespace API.Dtos;

public class ProductoListDto
{
    public int Id { get; set;}
    public string Nombre { get; set;}
    public decimal Precio { get; set; }
    public int IdMarca { get; set; }
    public string  Marca { get; set; }
    public int IdCategoria { get; set; }
    public string Categoria { get; set; }
}

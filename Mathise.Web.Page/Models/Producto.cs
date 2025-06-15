namespace Mathise.Web.Page.Models
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public decimal Precio { get; set; }
        public decimal? PrecioAnterior { get; set; }
        public string Categoria { get; set; }
        public int Descuento { get; set; }
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public List<string> Color { get; set; }
        public List<string> Talla { get; set; }
        public List<string> Imagenes { get; set; }
    }
}

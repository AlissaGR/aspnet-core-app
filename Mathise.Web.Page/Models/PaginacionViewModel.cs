namespace Mathise.Web.Page.Models
{
    public class PaginacionViewModel<T>
    {
        public IEnumerable<T> Items { get; set; } = Enumerable.Empty<T>();
        public int PaginaActual { get; set; }
        public int TotalPaginas { get; set; }

        public bool TieneAnterior => PaginaActual > 1;
        public bool TieneSiguiente => PaginaActual < TotalPaginas;
    }
}

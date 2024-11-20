namespace InventarioAVMR.Models
{
    public class Paginacion<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public Paginacion(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            //Calcular el total de páginas
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
        }
        //Verificar si hay una página anterior
        public bool HasPreviousPage => PageIndex > 1;
        //Verificar si hay una pagina siguiente
        public bool HasNextPage => PageIndex < TotalPages;

        public static async Task<Paginacion<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await Task.FromResult(source.Count());
            var items = source.Skip((pageIndex - 1)*pageSize).Take(pageSize).ToList();
            return new Paginacion<T>(items, count, pageIndex, pageSize);
        }
    }
}

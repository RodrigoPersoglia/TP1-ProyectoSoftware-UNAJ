using Data;

namespace ConnectionDataBase.Command
{
    public class LibrosRepository
    {
        private static readonly BibliotecaContext context = new BibliotecaContext();

        public static List<Libros> ListadoLibros()
        {
            return context.Libros.Where(l => l.Stock > 0).ToList();
        }

        public static bool ValidarLibro(string isbn)
        {
            if (context.Libros.Find(isbn) != null) { return true; }
            else return false;
        }

        public static bool ValidarStockLibro(string isbn)
        {
            if (context.Libros.Find(isbn).Stock > 0) { return true; }
            else return false;
        }

        public static void DescontarStockLibro(string isbn)
        {
            Libros libro = context.Libros.Find(isbn);
            libro.Stock -= 1;
            context.SaveChanges();
        }


    }
}

using ConnectionDataBase.Command;
using Data;

namespace Application.Services
{
    public class LibrosService
    {

        public static List<Libros> ListadoLibros()
        {
            return LibrosRepository.ListadoLibros();
        }

        public static bool ValidarLibro(string isbn)
        {
            return LibrosRepository.ValidarLibro(isbn);
        }

        public static bool ValidarStockLibro(string isbn)
        {
            return LibrosRepository.ValidarStockLibro(isbn);
        }

        public static void DescontarStockLibro(string isbn)
        {
            LibrosRepository.DescontarStockLibro(isbn);
        }

    }
}

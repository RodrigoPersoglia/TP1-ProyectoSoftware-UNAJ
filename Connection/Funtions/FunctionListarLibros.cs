using Application.Services;
using Data;

namespace Presentation.Funtions
{
    public class FunctionListarLibros
    {
        public static void SelectLibros()
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("Listado de libros disponibles");
                Console.WriteLine("-----------------------------");
                List<Libros> lista = LibrosService.ListadoLibros();
                foreach (Libros libro in lista)
                {
                    Console.WriteLine(libro.ToString());
                }
                Console.WriteLine("");
                Method.ingreso_str("Presione Enter para continuar ");
            }
            catch (Exception m) { Console.WriteLine("Eror: " + m.Message); Method.ingreso_str("Presione Enter para continuar "); }
        }

    }
}

using Application.Services;

namespace Presentation.Funtions
{
    public class FunctionAlquilar
    {
        public static void CreateAlquiler()
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("ALQUILER DE LIBROS");
                Console.WriteLine("-----------------");
                FunctionListarLibros.SelectLibros();
                string ISBN = Method.ingreso_str("Ingrese ISBN del libro: ");
                int numCliente = Method.ingreso_int("Ingrese el nº de cliente: ", 1, 99999999);
                Console.WriteLine(AlquileresService.CreateAlquiler(numCliente, ISBN));
                Method.ingreso_str("Presione Enter para continuar ");
            }

            catch (Exception m) { Console.WriteLine(m.Message); Method.ingreso_str("Presione Enter para continuar "); }
        }
    }
}

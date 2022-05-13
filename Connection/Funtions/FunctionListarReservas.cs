using Application.Services;
using Data;

namespace Presentation.Funtions
{
    public class FunctionListarReservas
    {

        public static void SelectReservas()
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("Listado de libros reservados");
                Console.WriteLine("-----------------------------");
                List<Alquileres> lista = AlquileresService.SelectReserva();
                foreach (Alquileres reserva in lista)
                {
                    Console.WriteLine(reserva.ListadoReservas());
                }
                Console.WriteLine("");
                Method.ingreso_str("Presione Enter para continuar ");
            }
            catch (Exception m) { Console.WriteLine("Eror: " + m.Message); Method.ingreso_str("Presione Enter para continuar "); }
        }
    }
}

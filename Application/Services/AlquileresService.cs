using AccesData.Command;
using Data;

namespace Application.Services
{
    public class AlquileresService
    {
        public static string CreateReserva(int numueroCliente, string isbn)
        {
            if (LibrosService.ValidarLibro(isbn) && ClienteService.ValidarCliente(numueroCliente))
            {
                if (LibrosService.ValidarStockLibro(isbn))
                {
                    AlquileresRepository.CreateReserva(numueroCliente, isbn);
                    LibrosService.DescontarStockLibro(isbn);
                    return "Reserva Confirmada";
                }
                else return "No hay stock del libro solicitado";

            }
            else return "Error en los datos ingresados. El cliente o el libro ingresado no existen";

        }

        public static string CreateAlquiler(int numueroCliente, string isbn)
        {
            if (LibrosService.ValidarLibro(isbn) && ClienteService.ValidarCliente(numueroCliente))
            {
                if (LibrosService.ValidarStockLibro(isbn))
                {
                    AlquileresRepository.CreateAlquiler(numueroCliente, isbn);
                    LibrosService.DescontarStockLibro(isbn);
                    return "Alquiler Confirmado";
                }
                else return "No hay stock del libro solicitado";
            }
            else return "Error en los datos ingresados. El cliente o el libro ingresado no existen";
        }


        public static List<Alquileres> SelectReserva()
        {
            return AlquileresRepository.SelectReserva();
        }

    }
}

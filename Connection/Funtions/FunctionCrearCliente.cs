using Application.Services;

namespace Presentation.Funtions
{
    public class FunctionCrearCliente
    {
        public static void CreateCliente()
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("CREAR CLIENTE NUEVO");
                Console.WriteLine("INGRESE LOS DATOS DEL CLIENTE ");
                string nombre = Method.ingreso_str("Nombre: ");
                string apellido = Method.ingreso_str("Apellido: ");
                string dni = (Method.ingreso_int("DNI(sin puntos): ", 1000000, 99000000)).ToString();
                string email = Method.ingreso_str("E-mail: ");
                Console.WriteLine(ClienteService.CreateCliente(nombre, apellido, dni, email));
                Method.ingreso_str("Presione Enter para continuar ");
            }
            catch (Exception m) { Console.WriteLine(m.Message); Method.ingreso_str("Presione Enter para continuar "); }
        }
    }
}

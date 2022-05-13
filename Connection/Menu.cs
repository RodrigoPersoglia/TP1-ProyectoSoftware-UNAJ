using Presentation;
using Presentation.Funtions;
namespace PrintMenu
{
    public class Menu
    {
        public static void ImprimirMenu()
        {
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("*           BIBLIOTECA MUNICIPAL          *");
            Console.WriteLine("*         Municipalidad 9 de Julio        *");
            Console.WriteLine("*******************************************");
            Console.WriteLine("");
            Console.WriteLine("********** MENU DE OPCIONES ***********");
            Console.WriteLine("***************************************");
            Console.WriteLine("");
            Console.WriteLine("Selecciones la opción deseada");
            Console.WriteLine("1) - Agregar Cliente");
            Console.WriteLine("2) - Reserva de Libros");
            Console.WriteLine("3) - Alquiler de Libros");
            Console.WriteLine("4) - Listado de Reservas");
            Console.WriteLine("5) - Listado de Libros Disponibles");
            Console.WriteLine("6) - Salir del sistema");
            int seleccion = Method.ingreso_int("Ingrese su seleccion: ", 1, 6);
            while (seleccion != 7)
            {
                bool prueba = false;
                switch (seleccion)
                {
                    case 1: FunctionCrearCliente.CreateCliente(); break;
                    case 2: FunctionReservar.CreateReserva(); break;
                    case 3: FunctionAlquilar.CreateAlquiler(); break;
                    case 4: FunctionListarReservas.SelectReservas(); break;
                    case 5: FunctionListarLibros.SelectLibros(); break;
                    case 6: prueba = true; break;
                    default: Console.WriteLine("Opcion invalida"); break;
                }

                if (prueba == true) { seleccion = 7; }
                else
                {
                    Console.Clear();
                    Console.WriteLine("*******************************************");
                    Console.WriteLine("*           BIBLIOTECA MUNICIPAL          *");
                    Console.WriteLine("*         Municipalidad 9 de Julio        *");
                    Console.WriteLine("*******************************************");
                    Console.WriteLine("");
                    Console.WriteLine("********** MENU DE OPCIONES ***********");
                    Console.WriteLine("***************************************");
                    Console.WriteLine("");
                    Console.WriteLine("Selecciones la opción deseada");
                    Console.WriteLine("1) - Agregar Cliente");
                    Console.WriteLine("2) - Reserva de Libros");
                    Console.WriteLine("3) - Alquiler de Libros");
                    Console.WriteLine("4) - Listado de Reservas");
                    Console.WriteLine("5) - Listado de Libros Disponibles");
                    Console.WriteLine("6) - Salir del sistema");
                    seleccion = Method.ingreso_int("Ingrese su seleccion: ", 1, 6);
                }
            }
        }


    }
}
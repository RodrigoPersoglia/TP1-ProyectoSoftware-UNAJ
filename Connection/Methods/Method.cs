namespace Presentation
{
    public class Method
    {
        public static int ingreso_int(string leyenda, int min, int max)
        {
            while (true)
            {
                try
                {
                    Console.Write(leyenda);
                    int numero = int.Parse(Console.ReadLine());
                    if (numero < min | numero > max)
                    {
                        throw new FueraRangoException();
                    }
                    return numero;
                }
                catch (FormatException a) { Console.WriteLine("Entrada invalida: " + a.Message); }
                catch (FueraRangoException) { Console.WriteLine("Entrada invalida: Debe ingresar un numero entre " + min + " y " + max); }
                catch (Exception r) { Console.WriteLine("Entrada invalida: " + r.Message); }
            }
        }

        public static string ingreso_str(string leyenda)
        {
            Console.Write(leyenda);
            string ingreso = Console.ReadLine();
            return ingreso;
        }

    }

    public class FueraRangoException : Exception { }
}
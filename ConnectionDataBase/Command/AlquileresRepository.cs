using ConnectionDataBase;
using Data;
using Microsoft.EntityFrameworkCore;

namespace AccesData.Command
{
    public class AlquileresRepository
    {
        private static readonly BibliotecaContext context = new BibliotecaContext();
        public static void CreateReserva(int numueroCliente, string isbn)
        {
            Alquileres alquiler = new Alquileres();
            alquiler.Cliente = context.Cliente.Single(c => c.ClienteID == numueroCliente);
            alquiler.Libros = context.Libros.Single(l => l.ISBN == isbn);
            alquiler.Estado = context.EstadoDeAlquileres.Single(e => e.EstadoId == 1);
            alquiler.FechaReserva = DateTime.Now;
            context.Alquileres.Add(alquiler);
            context.SaveChanges();
        }

        public static void CreateAlquiler(int numueroCliente, string isbn)
        {
            Alquileres alquiler = new Alquileres();
            alquiler.Cliente = context.Cliente.Single(c => c.ClienteID == numueroCliente);
            alquiler.Libros = context.Libros.Single(l => l.ISBN == isbn);
            alquiler.Estado = context.EstadoDeAlquileres.Single(e => e.EstadoId == 2);
            alquiler.FechaAlquiler = DateTime.Now;
            alquiler.FechaDevolucion = DateTime.Now.AddDays(7);
            context.Alquileres.Add(alquiler);
            context.SaveChanges();
        }

        public static List<Alquileres> SelectReserva()
        {
            EstadoDeAlquileres estado = context.EstadoDeAlquileres.Single(e => e.EstadoId == 1);
            return context.Alquileres.Where(a => a.Estado == estado).Include(a => a.Cliente).Include(a => a.Libros).Include(a => a.Estado).ToList();
        }


    }
}

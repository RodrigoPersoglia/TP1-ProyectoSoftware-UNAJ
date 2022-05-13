using System.ComponentModel.DataAnnotations;
namespace Data
{
    public class Alquileres
    {
        [Key]
        public int Id { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int Cliente_idx { get; set; }
        public virtual Libros Libros { get; set; }
        public string Libros_idx { get; set; }
        public virtual EstadoDeAlquileres Estado { get; set; }
        public int Estado_idx { get; set; }
        public DateTime? FechaAlquiler { get; set; }
        public DateTime? FechaReserva { get; set; }
        public DateTime? FechaDevolucion { get; set; }


        public string ListadoReservas()
        {
            return "Reserva n° " + Id.ToString() + " | Cliente: " + Cliente.Nombre + " " + Cliente.Apellido + " Num Cliente: " + Cliente.ClienteID + " | Libro: " + Libros.Titulo + " ISBN: " + Libros.ISBN + " | Fecha Reserva: " + FechaReserva.Value.ToString("dd/MM/yyyy");

        }

        public string ListadoAlquileres()
        {
            return "Alquiler n° " + Id.ToString() + " | Cliente: " + Cliente.Nombre + " " + Cliente.Apellido + " Num Cliente: " + Cliente.ClienteID + " | Libro: " + Libros.Titulo + " ISBN: " + Libros.ISBN + " | Fecha Alquiler: " + FechaAlquiler.Value.ToString("dd/MM/yyyy") + " Fecha Devolución: " + FechaDevolucion.Value.ToString("dd/MM/yyyy");

        }

    }
}

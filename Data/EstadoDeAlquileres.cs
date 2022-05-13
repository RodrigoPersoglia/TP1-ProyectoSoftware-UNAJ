using System.ComponentModel.DataAnnotations;
namespace Data

{
    public class EstadoDeAlquileres
    {
        [Key]
        public int EstadoId { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Alquileres> Alquileres { get; set; }

    }

}

using AccesData.Command;
using Data;

namespace Application.Services
{
    public class ClienteService
    {
        public static string CreateCliente(string nombre, string apellido, string dni, string email)
        {
            try
            {
                Cliente cli = new Cliente();
                cli.Nombre = nombre;
                cli.Apellido = apellido;
                cli.DNI = dni;
                cli.Email = email;
                ClienteRepository.CreateCliente(cli);
                return "Cliente Creado Correctamente";
            }
            catch (Exception) { return "Error en los datos ingresados"; }

        }

        public static bool ValidarCliente(int id)
        {
            return ClienteRepository.ValidarCliente(id);
        }

    }
}

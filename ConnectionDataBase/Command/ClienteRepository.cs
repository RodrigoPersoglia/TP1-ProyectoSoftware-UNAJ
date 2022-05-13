using ConnectionDataBase;
using Data;

namespace AccesData.Command
{
    public class ClienteRepository
    {
        private static readonly BibliotecaContext context = new BibliotecaContext();
        public static void CreateCliente(Cliente cliente)
        {
            context.Cliente.Add(cliente);
            context.SaveChanges();
        }

        public static bool ValidarCliente(int id)
        {
            if (context.Cliente.Find(id) != null) { return true; }
            else return false;
        }
    }
}

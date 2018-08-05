using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteDao
    {
        public static List<Cliente> clientes = new List<Cliente>();

        public void Add(Cliente cliente)
        {
            ClienteDao.clientes.Add(cliente);
        }
        public Cliente Buscar(string nome)
        {
            var resultado = ClienteDao.clientes.Where(c => c.Nome.Equals(nome)).FirstOrDefault();
            return resultado;
        }
    }
}

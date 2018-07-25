using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public void Add(Cliente cliente)
        {
            ClienteDao clienteDao = new ClienteDao();
            clienteDao.Add(cliente);
        }

        public Cliente Buscar(string nome)
        {
            ClienteDao clienteDao = new ClienteDao();
            return clienteDao.Buscar(nome);
        }
    }
}

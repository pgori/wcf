using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public bool Add(string nome, string cpf)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = nome;
            cliente.Cpf = cpf;

            ClienteDao clienteDao = new ClienteDao();
            clienteDao.Add(cliente);

            return true;
        }

        public Cliente Buscar(string nome)
        {
            ClienteDao clienteDao = new ClienteDao();
            return clienteDao.Buscar(nome);
        }

        public List<Cliente> getClientes()
        {
            return ClienteDao.clientes;
        }
    }
}

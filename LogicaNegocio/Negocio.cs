using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Negocio
    {
        List<Cliente> clientes;
       
        public Negocio()
        {
            clientes = new List<Cliente>();
        }

        public List<Cliente> Clientes { get => clientes; set => clientes = value; }

        public void Agregar(Cliente cliente)
        {
            if (cliente.Id == 0)
            {
                AccesoDatos.InsertarCliente(cliente);
            }
            else
            {

            }
        }
        public List<Cliente> LeerClientes()
        {
           return AccesoDatos.LeerClientes();
        }
    }
}

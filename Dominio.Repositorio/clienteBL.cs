using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//importar
using Dominio.Entidades;
using Infraestructura.Data.Sql;

namespace Dominio.Repositorio
{
    public class clienteBL
    {
        public List<clienteEntidad> listar()
        {
            clienteDAL cliente = new clienteDAL();

            return cliente.listar();

        }

        public string Agregar(clienteEntidad reg)
        {
            clienteDAL cliente = new clienteDAL();
            return cliente.Agregar(reg);
        }


    }
}

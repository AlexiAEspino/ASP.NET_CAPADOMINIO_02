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
    public class paisBL
    {
        public List<paisEntidad> listarPais()
        {
            paisDAL pais = new paisDAL();
            return pais.listarPais();
        }
     }
}

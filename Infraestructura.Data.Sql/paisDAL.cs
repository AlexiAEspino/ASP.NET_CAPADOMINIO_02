using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System.Data.SqlClient;
using System.Data;
using Dominio.Entidades;

namespace Infraestructura.Data.Sql
{
    public class paisDAL
    {
        conexionSQL conecta = new conexionSQL();

        public List<paisEntidad> listarPais() {
            List<paisEntidad> listaPais = new List<paisEntidad>();

            SqlCommand cmd = new SqlCommand("select * from tb_paises",conecta.CN);
            conecta.CN.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) {
                paisEntidad reg = new paisEntidad();
                reg.idpais = dr.GetString(0);
                reg.nombrepais = dr.GetString(1);

                listaPais.Add(reg);
            }

            dr.Close();
            conecta.CN.Close();
            return listaPais;
        }



    }
}

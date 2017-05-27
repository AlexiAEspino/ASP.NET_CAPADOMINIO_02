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
    public class clienteDAL
    {
        conexionSQL conecta = new conexionSQL();


        /************LISTADO DE CLIENTE**************/
        public List<clienteEntidad> listar() {

            List<clienteEntidad> lista= new List<clienteEntidad>();

            SqlCommand cmd = new SqlCommand("select * from tb_clientes",conecta.CN);
            conecta.CN.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) {
                clienteEntidad reg = new clienteEntidad();
                reg.idcliente = dr.GetString(0);
                reg.nombrecia = dr.GetString(1);
                reg.direccion = dr.GetString(2);
                reg.idpais = dr.GetString(3);
                reg.telefono = dr.GetString(4);

                lista.Add(reg);
                
            }

            dr.Close();
            conecta.CN.Close();
            
            return lista;
        }



        /************AGREGAR CLIENTE**************/

        public string Agregar(clienteEntidad reg) {
            string msg = "";

            try {

                SqlCommand cmd = new SqlCommand("insert into tb_clientes values(@id,@nom,@dir,@pais,@tel)", conecta.CN);
                conecta.CN.Open();

                cmd.Parameters.AddWithValue("@id",reg.idcliente);
                cmd.Parameters.AddWithValue("@nom",reg.nombrecia);
                cmd.Parameters.AddWithValue("@dir",reg.direccion);
                cmd.Parameters.AddWithValue("@pais",reg.idpais);
                cmd.Parameters.AddWithValue("@tel", reg.telefono);

                cmd.ExecuteNonQuery();

                msg = "Registro Agregado";
                
            }
            catch (SqlException e) {
                msg = e.Message;
            }
            finally {
                conecta.CN.Close();
            }
            
            return msg;
        }




        /************ACTUALIZAR CLIENTE**************/


        /************ELIMINAR CLIENTE**************/


    }
}

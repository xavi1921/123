using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Datos
{
    public class Tipo_EmpleadosCD
    {

        protected static string dbConnectionString = "workstation id=DBFonet.mssql.somee.com;packet size=4096;user id=FONET;pwd=xavi1921;data source=DBFonet.mssql.somee.com;persist security info=False;initial catalog=DBFonet";

        public static List<Tipo_Empleados> VerTodosTipoEmpleado()
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            List<Tipo_Empleados> ListaTipoEmpleados = new List<Tipo_Empleados>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarTodosTipoEmpleado", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ListaTipoEmpleados.Add(new Tipo_Empleados
                        {
                            idTipo = dr.GetInt32(0),
                            cargo = dr.GetString(1),
                            descripcion = dr.GetString(2)
                        });
                    }
                    dr.Close();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return ListaTipoEmpleados;
        }

        public static List<Tipo_Empleados> VerTipoEmpleado(string cargo)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            List<Tipo_Empleados> ListarTipoEmpleado = new List<Tipo_Empleados>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarTipoEmpleado " +
                        "@Cargo", conn);
                    cmd.Parameters.AddWithValue("@Cargo", cargo); 
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ListarTipoEmpleado.Add(new Tipo_Empleados
                        {
                            idTipo = dr.GetInt32(0),
                            cargo = dr.GetString(1),
                            descripcion = dr.GetString(2)
                        });
                    }
                    dr.Close();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return ListarTipoEmpleado;
        }

        public static bool InsertarTipoEmpleado(Tipo_Empleados p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_InsertarTipoEmpleado " +
                        "@ID_Cargo, " +
                        "@Cargo, " +
                        "@Descripcion, ", conn);
                    cmd.Parameters.AddWithValue("@ID_Cargo", p.idTipo);
                    cmd.Parameters.AddWithValue("@Cargo", p.cargo);
                    cmd.Parameters.AddWithValue("@Descripcion", p.descripcion);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                correcto = false;
            }
            finally
            {
                conn.Close();
            }
            return correcto;
        }

        public static bool Actualizar(Tipo_Empleados p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_EditarTipoEmpleado " +
                       "@ID_Cargo, " +
                       "@Cargo, " +
                       "@Descripcion, ", conn);
                    cmd.Parameters.AddWithValue("@ID_Cargo", p.idTipo);
                    cmd.Parameters.AddWithValue("@Cargo", p.cargo);
                    cmd.Parameters.AddWithValue("@Descripcion", p.descripcion);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                correcto = false;
            }
            finally
            {
                conn.Close();
            }
            return correcto;
        }

        public static bool Eliminar(int idTipo)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_EliminarTipoEmpleado" +
                        " @ID_Cargo", conn);
                    cmd.Parameters.AddWithValue("@ID_Cargo", idTipo);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                correcto = false;
            }
            catch (Exception)
            {
                correcto = false;
            }
            finally
            {
                conn.Close();
            }
            return correcto;
        }
    }
}

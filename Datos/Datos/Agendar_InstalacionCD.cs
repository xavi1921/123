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
    public class Agendar_InstalacionCD
    {
        protected static string dbConnectionString = "workstation id=DBFonet.mssql.somee.com;packet size=4096;user id=FONET;pwd=xavi1921;data source=DBFonet.mssql.somee.com;persist security info=False;initial catalog=DBFonet";

        public static List<Agendar_Instalacion> VerTodasInstalacionesAgendadas()
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            List<Agendar_Instalacion> ListarInstalacionesAgendadas = new List<Agendar_Instalacion>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarTodasInstalaciones", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ListarInstalacionesAgendadas.Add(new Agendar_Instalacion
                        {
                            idInstalacion = dr.GetInt32(0),
                            cedulaCliente = dr.GetString(1),
                            cedulaEmpleado = dr.GetString(2),
                            fechaInstalacion = dr.GetDateTime(3),
                            Instalado = dr.GetBoolean(4),
                            Observaciones = dr.GetString(5)
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
            return ListarInstalacionesAgendadas;
        }

        public static List<Agendar_Instalacion> VerInstalacionesAgendadas(string cedulaCliente, DateTime fechaInstalacion)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            List<Agendar_Instalacion> ListaInstalacionesAgendadas = new List<Agendar_Instalacion>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarCortesReconexiones " +
                        "@Cedula_Cliente, " +
                        "@Fecha_Instalacion" , conn);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", cedulaCliente);
                    cmd.Parameters.AddWithValue("@Fecha_Instalacion", fechaInstalacion);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ListaInstalacionesAgendadas.Add(new Agendar_Instalacion
                        {
                            idInstalacion = dr.GetInt32(0),
                            cedulaCliente = dr.GetString(1),
                            cedulaEmpleado = dr.GetString(2),
                            fechaInstalacion = dr.GetDateTime(3),
                            Instalado = dr.GetBoolean(4),
                            Observaciones = dr.GetString(5)
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
            return ListaInstalacionesAgendadas;
        }

        public static bool InsertarAgendaInstalacion(Agendar_Instalacion p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_InsertarInstalacion " +
                        "@Cedula_Cliente, " +
                        "@Cedula_Empleado, " +
                        "@Fecha_Instalacion, " +
                        "@Instalado, " +
                        "@Observaciones", conn);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", p.cedulaCliente);
                    cmd.Parameters.AddWithValue("@Cedula_Empleado", p.cedulaEmpleado);
                    cmd.Parameters.AddWithValue("@Fecha_Instalacion", p.fechaInstalacion);
                    cmd.Parameters.AddWithValue("@Pendiente", p.Instalado);
                    cmd.Parameters.AddWithValue("@Observaciones", p.Observaciones);
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

        public static bool Actualizar(Agendar_Instalacion p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_EditarCORTE_RECONEXION " +
                        "@Cedula_Cliente, " +
                        "@Cedula_Empleado, " +
                        "@Fecha_Instalacion, " +
                        "@Instalado, " +
                        "@Observaciones", conn);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", p.cedulaCliente);
                    cmd.Parameters.AddWithValue("@Cedula_Empleado", p.cedulaEmpleado);
                    cmd.Parameters.AddWithValue("@Fecha_Instalacion", p.fechaInstalacion);
                    cmd.Parameters.AddWithValue("@Pendiente", p.Instalado);
                    cmd.Parameters.AddWithValue("@Observaciones", p.Observaciones);
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

        public static bool Eliminar(int id)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_EliminarInstalacion " +
                        "@ID_Agendar_Instalacion", conn);
                    cmd.Parameters.AddWithValue("@ID_Agendar_Instalacion", id);
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

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
    public class Fecha_PagosCD
    {

        protected static string dbConnectionString = "workstation id=DBFonet.mssql.somee.com;packet size=4096;user id=FONET;pwd=xavi1921;data source=DBFonet.mssql.somee.com;persist security info=False;initial catalog=DBFonet";

        public static List<Fecha_Pagos> VerTodosFechaPago()
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            List<Fecha_Pagos> ListaFechaPagos = new List<Fecha_Pagos>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarTodosFechaPago", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ListaFechaPagos.Add(new Fecha_Pagos
                        {
                            IdPago = dr.GetInt32(0),
                            CedulaCliente = dr.GetString(1),
                            IdInstalacion = dr.GetInt32(2),
                            FechaPago = dr.GetDateTime(3),
                            PlazoVencido = dr.GetBoolean(4),
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
            return ListaFechaPagos;
        }
        
        public static Fecha_Pagos VerFechaPagos(int id)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            Fecha_Pagos fecha_Pagos = null;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarFechaPago " +
                        "@ID_PAGO", conn);
                    cmd.Parameters.AddWithValue("@ID_PAGO", id);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        fecha_Pagos = new Fecha_Pagos
                        {
                            IdPago = dr.GetInt32(0),
                            CedulaCliente = dr.GetString(1),
                            IdInstalacion = dr.GetInt32(2),
                            FechaPago = dr.GetDateTime(3),
                            PlazoVencido = dr.GetBoolean(4),
                            Observaciones = dr.GetString(5)
                        };
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
            return fecha_Pagos;
        }

        public static Fecha_Pagos VerFechaPagoCedula(string cedula)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            Fecha_Pagos fecha_Pagos = null;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarFechaPagoCedula " +
                        "@Cedula_Cliente", conn);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", cedula);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        fecha_Pagos = new Fecha_Pagos
                        {
                            IdPago = dr.GetInt32(0),
                            CedulaCliente = dr.GetString(1),
                            IdInstalacion = dr.GetInt32(2),
                            FechaPago = dr.GetDateTime(3),
                            PlazoVencido = dr.GetBoolean(4),
                            Observaciones = dr.GetString(5)
                        };
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
            return fecha_Pagos;
        }

        public static bool InsertarFechaPagos(Fecha_Pagos p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_InsertarFecha_Pagos " +
                        "@Cedula_Cliente, " +
                        "@ID_INSTALACION, " +
                        "@FECHA_PAGO," +
                        "@PLAZO_VENCIDO" +
                        "@OBSERVACIONES", conn);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", p.CedulaCliente);
                    cmd.Parameters.AddWithValue("@ID_INSTALACION", p.IdInstalacion);
                    cmd.Parameters.AddWithValue("@FECHA_PAGO", p.FechaPago);
                    cmd.Parameters.AddWithValue("@PLAZO_VENCIDO", p.PlazoVencido);
                    cmd.Parameters.AddWithValue("@OBSERVACIONES", p.Observaciones);
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
       
        public static bool Actualizar(Fecha_Pagos p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_EditarFECHA_PAGOS" +
                        "@ID_PAGO, " +
                        "@Cedula_Cliente, " +
                        "@ID_INSTALACION, " +
                        "@FECHA_PAGO," +
                        "@PLAZO_VENCIDO" +
                        "@OBSERVACIONES", conn);
                    cmd.Parameters.AddWithValue("@ID_PAGO", p.IdPago);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", p.CedulaCliente);
                    cmd.Parameters.AddWithValue("@ID_INSTALACION", p.IdInstalacion);
                    cmd.Parameters.AddWithValue("@FECHA_PAGO", p.FechaPago);
                    cmd.Parameters.AddWithValue("@PLAZO_VENCIDO", p.PlazoVencido);
                    cmd.Parameters.AddWithValue("@OBSERVACIONES", p.Observaciones);
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

        public static bool Eliminar(int id)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_EliminarFECHA_PAGOS " +
                        "@@ID_PAGO", conn);
                    cmd.Parameters.AddWithValue("@@ID_PAGO", id);
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

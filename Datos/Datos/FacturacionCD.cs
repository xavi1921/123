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
    public class FacturacionCD
    {
        protected static string dbConnectionString = "workstation id=DBFonet.mssql.somee.com;packet size=4096;user id=FONET;pwd=xavi1921;data source=DBFonet.mssql.somee.com;persist security info=False;initial catalog=DBFonet";

        public static List<Facturacion> VerTodasFacturaciones()
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            List<Facturacion> ListarFacturacion = new List<Facturacion>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarTodasFacturacion", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ListarFacturacion.Add(new Facturacion
                        {
                            idFacturacion = dr.GetInt32(0),
                            cedulaCliente = dr.GetString(1),
                            cedulaEmpleado = dr.GetString(2),
                            idContrato = dr.GetInt32(3),
                            idCorteReconexion = dr.GetInt32(4),
                            fechaPago = dr.GetDateTime(5),
                            totalPago = dr.GetDouble(6)
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
            return ListarFacturacion;
        }

        public static List<Facturacion> VerFacturacionCedula(string cedulaCliente)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            List<Facturacion> ListarFacturtacionCedula = new List<Facturacion>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarFacturacionCedula " +
                        "@Cedula_Cliente, ",conn);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", cedulaCliente);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ListarFacturtacionCedula.Add(new Facturacion
                        {
                            idFacturacion = dr.GetInt32(0),
                            cedulaCliente = dr.GetString(1),
                            cedulaEmpleado = dr.GetString(2),
                            idContrato = dr.GetInt32(3),
                            idCorteReconexion = dr.GetInt32(4),
                            fechaPago = dr.GetDateTime(5),
                            totalPago = dr.GetDouble(6)
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
            return ListarFacturtacionCedula;
        }

        public static List<Facturacion> VerFacturacionFecha(DateTime fechaFacturacion)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            List<Facturacion> ListaFacturacionFechas = new List<Facturacion>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarCortesReconexiones " +
                        "@Fecha_Facturacion", conn);
                    cmd.Parameters.AddWithValue("@Fecha_Facturacion", fechaFacturacion);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ListaFacturacionFechas.Add(new Facturacion
                        {
                            idFacturacion = dr.GetInt32(0),
                            cedulaCliente = dr.GetString(1),
                            cedulaEmpleado = dr.GetString(2),
                            idContrato = dr.GetInt32(3),
                            idCorteReconexion = dr.GetInt32(4),
                            fechaPago = dr.GetDateTime(5),
                            totalPago = dr.GetDouble(6)
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
            return ListaFacturacionFechas;
        }

        public static bool InsertarFacturacion(Facturacion p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_InsertarFacturacion " +
                        "@Cedula_Cliente, " +
                        "@Cedula_Empleado, " +
                        "@ID_Contrato, " +
                        "@ID_Corte_Reconexion, " +
                        "@Fecha_Pago, " +
                        "@Total_Pago", conn);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", p.cedulaCliente);
                    cmd.Parameters.AddWithValue("@Cedula_Empleado", p.cedulaEmpleado);
                    cmd.Parameters.AddWithValue("@ID_Contrato", p.idContrato);
                    cmd.Parameters.AddWithValue("@ID_Corte_Reconexion", p.idCorteReconexion);
                    cmd.Parameters.AddWithValue("@Fecha_Pago", p.fechaPago);
                    cmd.Parameters.AddWithValue("@Total_Pago", p.totalPago);
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

        public static bool Actualizar(Facturacion p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_EditarFacturacion " +
                        "@Cedula_Cliente, " +
                        "@Cedula_Empleado, " +
                        "@ID_Contrato, " +
                        "@ID_Corte_Reconexion, " +
                        "@Fecha_Pago, " +
                        "@Total_Pago", conn);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", p.cedulaCliente);
                    cmd.Parameters.AddWithValue("@Cedula_Empleado", p.cedulaEmpleado);
                    cmd.Parameters.AddWithValue("@ID_Contrato", p.idContrato);
                    cmd.Parameters.AddWithValue("@ID_Corte_Reconexion", p.idCorteReconexion);
                    cmd.Parameters.AddWithValue("@Fecha_Pago", p.fechaPago);
                    cmd.Parameters.AddWithValue("@Total_Pago", p.totalPago);
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
                    SqlCommand cmd = new SqlCommand("exec pa_EliminarFacturacion " +
                        "@ID_FACTURACION", conn);
                    cmd.Parameters.AddWithValue("@ID_FACTURACION", id);
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

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
    public class Contrato_ServicioCD
    {
        protected static string dbConnectionString = "workstation id=DBFonet.mssql.somee.com;packet size=4096;user id=FONET;pwd=xavi1921;data source=DBFonet.mssql.somee.com;persist security info=False;initial catalog=DBFonet";

        public static List<Contrato_Servicio> VerTodosContratoServicio()
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            List<Contrato_Servicio> ListaContratoServicio = new List<Contrato_Servicio>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarTodosContratoServicio", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ListaContratoServicio.Add(new Contrato_Servicio
                        {
                            IdContrato = dr.GetInt32(0),
                            CedulaCliente = dr.GetString(1),
                            IdPlanMegas = dr.GetInt32(2),
                            IdInstalacion = dr.GetInt32(3),
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
            return ListaContratoServicio;
        }

        public static Contrato_Servicio VerContratoServicio(int id)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            Contrato_Servicio contrato_Servicio = null;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarContratoServicio " +
                        "@ID_CONTRTATO", conn);
                    cmd.Parameters.AddWithValue("@ID_CONTRTATO", id);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        contrato_Servicio = new Contrato_Servicio
                        {
                            IdContrato = dr.GetInt32(0),
                            CedulaCliente = dr.GetString(1),
                            IdPlanMegas = dr.GetInt32(2),
                            IdInstalacion = dr.GetInt32(3)
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
            return contrato_Servicio;
        }

        public static Contrato_Servicio VerContratoServicioCedula(string cedula)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            Contrato_Servicio contrato_Servicio = null;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarContratoServicioCedula " +
                        "@Cedula_Cliente", conn);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", cedula);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        contrato_Servicio = new Contrato_Servicio
                        {
                            IdContrato = dr.GetInt32(0),
                            CedulaCliente = dr.GetString(1),
                            IdPlanMegas = dr.GetInt32(2),
                            IdInstalacion = dr.GetInt32(3)
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
            return contrato_Servicio;
        }

        public static bool InsertarContratoServicio(Contrato_Servicio p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_InsertarCONTRATO_SERVICIO " +
                        "@Cedula_Cliente, " +
                        "@ID_PLAN_MEGAS, " +
                        "@ID_INSTALACION", conn);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", p.CedulaCliente);
                    cmd.Parameters.AddWithValue("@ID_PLAN_MEGAS", p.IdPlanMegas);
                    cmd.Parameters.AddWithValue("@ID_INSTALACION", p.IdInstalacion);
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

        public static bool Actualizar(Contrato_Servicio p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_EditarCONTRATO_SERVICIO" +
                        "@ID_CONTRATO, " +
                        "@Cedula_Cliente, " +
                        "@ID_PLAN_MEGAS, " +
                        "@ID_INSTALACION", conn);
                    cmd.Parameters.AddWithValue("@ID_CONTRATO", p.IdContrato);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", p.CedulaCliente);
                    cmd.Parameters.AddWithValue("@ID_PLAN_MEGAS", p.IdPlanMegas);
                    cmd.Parameters.AddWithValue("@ID_INSTALACION", p.IdInstalacion);
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
                    SqlCommand cmd = new SqlCommand("exec pa_EliminarCONTRATO_SERVICIO " +
                        "@ID_CONTRATO", conn);
                    cmd.Parameters.AddWithValue("@ID_CONTRATO", id);
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

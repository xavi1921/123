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
    public class Corte_ReconexionCD
    {
        protected static string dbConnectionString = "workstation id=DBFonet.mssql.somee.com;packet size=4096;user id=FONET;pwd=xavi1921;data source=DBFonet.mssql.somee.com;persist security info=False;initial catalog=DBFonet";

        public static List<Corte_Reconexion> VerTodosCortesReconexiones()
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            List<Corte_Reconexion> listaCorteReconexion = new List<Corte_Reconexion>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarTodosCortesReconexiones", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listaCorteReconexion.Add(new Corte_Reconexion
                        {
                            IdCorteReconexion = dr.GetInt32(0),
                            CedulaCliente = dr.GetString(1),
                            FechaCorte = dr.GetDateTime(2),
                            FechaReconexion = dr.GetDateTime(3),
                            Observaciones = dr.GetString(4)
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
            return listaCorteReconexion;
        }
       
        public static List<Corte_Reconexion> VerCortesReconexiones(string cedula, DateTime fechaCorte, DateTime fechaReconexion)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            List<Corte_Reconexion> listaCorteReconexion = new List<Corte_Reconexion>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarCortesReconexiones " +
                        "@Cedula_Cliente, " +
                        "@FECHA_CORTE, " +
                        "@Fecha_RECONEXION", conn);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", cedula);
                    cmd.Parameters.AddWithValue("@FECHA_CORTE", fechaCorte);
                    cmd.Parameters.AddWithValue("@Fecha_RECONEXION", fechaReconexion);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listaCorteReconexion.Add(new Corte_Reconexion
                        {
                            IdCorteReconexion = dr.GetInt32(0),
                            CedulaCliente = dr.GetString(1),
                            FechaCorte = dr.GetDateTime(2),
                            FechaReconexion = dr.GetDateTime(3),
                            Observaciones = dr.GetString(4)
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
            return listaCorteReconexion;
        }
        
        public static Corte_Reconexion VerCorteReconexionId(int id)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            Corte_Reconexion corte_Reconexion = null;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarCorteReconexion " +
                        "@Valor", conn);
                    cmd.Parameters.AddWithValue("@Valor", id);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        corte_Reconexion = new Corte_Reconexion
                        {
                            IdCorteReconexion = dr.GetInt32(0),
                            CedulaCliente = dr.GetString(1),
                            FechaCorte = dr.GetDateTime(2),
                            FechaReconexion = dr.GetDateTime(3),
                            Observaciones = dr.GetString(4)
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
            return corte_Reconexion;
        }

        public static bool InsertarCorteReconexion(Corte_Reconexion p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_InsertarCORTE_RECONEXION " +
                        "@Cedula_Cliente, " +
                        "@Fecha_CORTE, " +
                        "@Fecha_RECONEXION, " +
                        "@Observaciones", conn);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", p.CedulaCliente);
                    cmd.Parameters.AddWithValue("@Fecha_CORTE", p.FechaCorte);
                    cmd.Parameters.AddWithValue("@Fecha_RECONEXION", p.FechaReconexion);
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
        
        public static bool Actualizar(Corte_Reconexion p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_EditarCORTE_RECONEXION " +
                        "@ID_CORTE_RECONEXION, " +
                        "@Cedula_Cliente, " +
                        "@Fecha_CORTE, " +
                        "@Fecha_RECONEXION, " +
                        "@Observaciones", conn);
                    cmd.Parameters.AddWithValue("@ID_CORTE_RECONEXION", p.IdCorteReconexion);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", p.CedulaCliente);
                    cmd.Parameters.AddWithValue("@Fecha_CORTE", p.FechaCorte);
                    cmd.Parameters.AddWithValue("@Fecha_RECONEXION", p.FechaReconexion);
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

        public static bool Eliminar(int id)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_EliminarCORTE_RECONEXION " +
                        "@ID_CORTE_RECONEXION", conn);
                    cmd.Parameters.AddWithValue("@ID_CORTE_RECONEXION", id);
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

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
    public class Tipo_Plan_MegasCD
    {
        protected static string dbConnectionString = "workstation id=DBFonet.mssql.somee.com;packet size=4096;user id=FONET;pwd=xavi1921;data source=DBFonet.mssql.somee.com;persist security info=False;initial catalog=DBFonet";

        public static List<Tipo_Plan_Megas> VerTodosPlanes()
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            List<Tipo_Plan_Megas> ListarPlanesMegas = new List<Tipo_Plan_Megas>();
            //try
            //{
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarTodosPlanMegas", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ListarPlanesMegas.Add(new Tipo_Plan_Megas
                        {
                            IdPlanMegas = dr.GetInt32(0),
                            Megas = dr.GetString(1),
                            Costo = dr.GetDecimal(2)
                        });
                    }
                    dr.Close();
                }
            //}
            //catch (Exception)
            //{

            //}
            //finally
            //{
                conn.Close();
            //}
            return ListarPlanesMegas;
        }

        public static List<Tipo_Plan_Megas> VerPlanesMegas(string megas)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            List<Tipo_Plan_Megas> ListarPlanesMegas = new List<Tipo_Plan_Megas>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarPlanMegas " +
                        "@Megas", conn);
                    cmd.Parameters.AddWithValue("@Megas", megas);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ListarPlanesMegas.Add(new Tipo_Plan_Megas
                        {
                            IdPlanMegas = dr.GetInt32(0),
                            Megas = dr.GetString(1),
                            Costo = dr.GetDecimal(2)
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
            return ListarPlanesMegas;
        }

        public static bool InsertarTipoMegas(Tipo_Plan_Megas p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_InsertarPlanMegas " +
                        "@Megas, " +
                        "@Costo, ", conn);
                    cmd.Parameters.AddWithValue("@Megas", p.Megas);
                    cmd.Parameters.AddWithValue("@Costo", p.Costo);
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

        public static bool Actualizar(Tipo_Plan_Megas p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_EditarPlanMegas " +
                       "@Megas, " +
                       "@Costo, ", conn);
                    cmd.Parameters.AddWithValue("@Megas", p.Megas);
                    cmd.Parameters.AddWithValue("@Costo", p.Costo);                  
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
                    SqlCommand cmd = new SqlCommand("exec pa_EliminarPlanMegas" +
                        "@ID_Tipo_Plan_Megas", conn);
                    cmd.Parameters.AddWithValue("@ID_Tipo_Plan_Megas", idTipo);
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

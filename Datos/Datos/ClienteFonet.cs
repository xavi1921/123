using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Entidades;

namespace Datos.Datos
{
    public class ClienteFonet
    {
        protected static string dbConnectionString = "workstation id=DBFonet.mssql.somee.com;packet size=4096;user id=FONET;pwd=xavi1921;data source=DBFonet.mssql.somee.com;persist security info=False;initial catalog=DBFonet";

        public static List<Entidades.Entidades.ClienteFonet> VerClientes()
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            List<Entidades.Entidades.ClienteFonet> listaClientes = new List<Entidades.Entidades.ClienteFonet>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec fo_MostrarTodosClientes", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listaClientes.Add(new Entidades.Entidades.ClienteFonet
                        {
                            NroContrato = dr.GetInt32(0),
                            Cedula = dr.GetString(1),
                            Nombres = dr.GetString(2),
                            Apellidos = dr.GetString(3),
                            Correo = dr.GetString(4),
                            Telefono = dr.GetString(5),
                            Direccion = dr.GetString(6),
                            Referencia = dr.GetString(7),
                            Coordenadas = dr.GetString(8),
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
            return listaClientes;
        }

        public static bool InsertarClienteF(Entidades.Entidades.ClienteFonet p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec fo_InsertarCliente " +
                        "@NroContrato"+
                        "@Cedula_Cliente, " +
                        "@Nombres, " +
                        "@Apellidos, " +
                        "@Correo, " +
                        "@Telefono, " +
                        "@Direccion"+
                        "@Referencia"+
                        "@Coordenadas", conn);
                    cmd.Parameters.AddWithValue("@NroContrato", p.NroContrato);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", p.Cedula);
                    cmd.Parameters.AddWithValue("@Nombres", p.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", p.Apellidos);
                    cmd.Parameters.AddWithValue("@Correo", p.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", p.Direccion);
                    cmd.Parameters.AddWithValue("@Referencia", p.Referencia);
                    cmd.Parameters.AddWithValue("@Coordenadas", p.Coordenadas);
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

        public static bool Actualizar(Entidades.Entidades.ClienteFonet p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_EditarCliente " +
                        "@NroContrato"+
                        "@Cedula_Cliente, " +
                        "@Nombres, " +
                        "@Apellidos, " +
                        "@Correo, " +
                        "@Telefono, " +
                        "@Direccion"+
                        "@Referencia"+
                        "Coordenadas", conn);
                    cmd.Parameters.AddWithValue("@NroContrato", p.NroContrato);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", p.Cedula);
                    cmd.Parameters.AddWithValue("@Nombres", p.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", p.Apellidos);
                    cmd.Parameters.AddWithValue("@Correo", p.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", p.Direccion);
                    cmd.Parameters.AddWithValue("@Referencia", p.Referencia);
                    cmd.Parameters.AddWithValue("@Coordenadas", p.Coordenadas);
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
    }
}

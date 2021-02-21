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
    public class ClienteCD
    {
        protected static string dbConnectionString = "workstation id=DBFonet.mssql.somee.com;packet size=4096;user id=FONET;pwd=xavi1921;data source=DBFonet.mssql.somee.com;persist security info=False;initial catalog=DBFonet";

        public static List<Cliente> VerClientes()
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            List<Cliente> listaClientes = new List<Cliente>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarTodosClientes", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listaClientes.Add(new Cliente
                        {
                            Cedula = dr.GetString(0),
                            Nombres = dr.GetString(1),
                            Apellidos = dr.GetString(2),
                            Correo = dr.GetString(3),
                            Telefono = dr.GetString(4),
                            Direccion = dr.GetString(5)
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
        
        public static Cliente VerCliente(string cedulaCliente)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            Cliente cliente = null;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarCliente " +
                        "@Valor", conn);
                    cmd.Parameters.AddWithValue("@Valor", cedulaCliente);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cliente = new Cliente
                        {
                            Cedula = dr.GetString(0),
                            Nombres = dr.GetString(1),
                            Apellidos = dr.GetString(2),
                            Correo = dr.GetString(3),
                            Telefono = dr.GetString(4),
                            Direccion = dr.GetString(5)
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
            return cliente;
        }

        public static bool ExisteCliente(string cedulaCliente)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool existe = false;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec cp_ListarClientesCedula " +
                        "@Valor", conn);
                    cmd.Parameters.AddWithValue("@Valor", cedulaCliente);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        existe = true;
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
            return existe;
        }

        public static bool InsertarCliente(Cliente p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_InsertarCliente " +
                        "@Cedula_Cliente, " +
                        "@Nombres, " +
                        "@Apellidos, " +
                        "@Correo, " +
                        "@Telefono, " +
                        "@Direccion", conn);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", p.Cedula);
                    cmd.Parameters.AddWithValue("@Nombres", p.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", p.Apellidos);
                    cmd.Parameters.AddWithValue("@Correo", p.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", p.Direccion);
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

        public static bool Actualizar(Cliente p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_EditarCliente " +
                        "@Cedula_Cliente, " +
                        "@Nombres, " +
                        "@Apellidos, " +
                        "@Correo, " +
                        "@Telefono, " +
                        "@Direccion", conn);
                    cmd.Parameters.AddWithValue("@Cedula_Cliente", p.Cedula);
                    cmd.Parameters.AddWithValue("@Nombres", p.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", p.Apellidos);
                    cmd.Parameters.AddWithValue("@Correo", p.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", p.Direccion);
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

        public static bool Eliminar(string cedula)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_EliminarCliente" +
                        " @Cedula_Cliente", conn);
                    cmd.Parameters.AddWithValue("@cedula", cedula);
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

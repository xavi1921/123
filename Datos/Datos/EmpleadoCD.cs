using Datos.ServiciosEmail;
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
    public class EmpleadoCD
    {

        protected static string dbConnectionString = "workstation id=DBFonet.mssql.somee.com;packet size=4096;user id=FONET;pwd=xavi1921;data source=DBFonet.mssql.somee.com;persist security info=False;initial catalog=DBFonet";

        public static List<Empleado> VerEmpleados()
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            List<Empleado> listaEmpleados = new List<Empleado>();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarTodosEmpleados", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listaEmpleados.Add(new Empleado
                        {
                            Cedula_Empleado = dr.GetString(0),
                            Nombre = dr.GetString(1),
                            Apellido = dr.GetString(2),
                            Correo = dr.GetString(3),
                            Telefono = dr.GetString(4),
                            Direccion = dr.GetString(5),
                            Fecha_Nacimiento= dr.GetDateTime(6),
                            ID_Tipo_Empleado=dr.GetInt32(7),
                            Fecha_Contrato=dr.GetDateTime(8),
                            Contraseña=dr.GetString(9)
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
            return listaEmpleados;
        }

        public static string recuperarPassword(string userRequesting)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            try
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("select * from EMPLEADO where CORREO='" + userRequesting + "'", conn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        string Nombres = dr.GetString(1) + " " + dr.GetString(2);
                        string Correo = dr.GetString(3);
                        string password = dr.GetString(9);

                        var servicioCorreo = new SistemaSoporteCorreo();
                        servicioCorreo.sendEmail(
                            asunto: "SYSTEM: Password recovery request",
                            cuerpo: "Hola, " + Nombres + "\nEstas intentado recuperar tu contraseña.\n" +
                            "Tu contraseña es: " + password,
                            destinatario: new List<string> { Correo }
                            );
                        return "Hola, " + Nombres + " hemos enviado tu contraseña a tu correo.";
                    }
                    else
                        return "Lo sentimos, no tiene una cuenta con ese correo electronico.";
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepeciones("Error al recuperar contraseña.", ex);
            }
            finally
            {
                conn.Close();
            }
            return "";
        }

        public static Empleado VerEmpleado(string cedulaEmpleado)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            Empleado empleado = null;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("exec pa_MostrarEmpleado " +
                        "@Valor", conn);
                    cmd.Parameters.AddWithValue("@Valor", cedulaEmpleado);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        empleado = new Empleado
                        {
                            Cedula_Empleado = dr.GetString(0),
                            Nombre = dr.GetString(1),
                            Apellido = dr.GetString(2),
                            Correo = dr.GetString(3),
                            Telefono = dr.GetString(4),
                            Direccion = dr.GetString(5),
                            Fecha_Nacimiento = dr.GetDateTime(6),
                            ID_Tipo_Empleado = dr.GetInt32(7),
                            Fecha_Contrato = dr.GetDateTime(8),
                            Contraseña = dr.GetString(10)
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
            return empleado;
        }

        public static bool ExisteEmpleado(string cedulaEmpleado)
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
                    cmd.Parameters.AddWithValue("@Valor", cedulaEmpleado);
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

        public static bool InsertarEmpleado(Empleado p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_InsertarEmpleado " +
                        "@Cedula_Empleado, " +
                        "@Nombres, " +
                        "@Apellidos, " +
                        "@Correo, " +
                        "@Telefono, " +
                        "@Direccion" +
                        "@Fecha_Nacimiento" +
                        "@ID_Tipo" +
                        "@Fecha_Contrato" +
                        "@Contraseña", conn);
                    cmd.Parameters.AddWithValue("@Cedula_Empleado", p.Cedula_Empleado);
                    cmd.Parameters.AddWithValue("@Nombres", p.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", p.Apellido);
                    cmd.Parameters.AddWithValue("@Correo", p.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", p.Direccion);
                    cmd.Parameters.AddWithValue("@Fecha_Nacimiento", p.Fecha_Nacimiento);
                    cmd.Parameters.AddWithValue("@ID_Tipo", p.ID_Tipo_Empleado);
                    cmd.Parameters.AddWithValue("@Fecha_Contrato", p.Fecha_Contrato);
                    cmd.Parameters.AddWithValue("@Contraseña", p.Contraseña);
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

        public static bool Actualizar(Empleado p)
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            bool correcto = true;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("exec pa_EditarEmpleado " +
                        "@Cedula_Empleado, " +
                        "@Nombres, " +
                        "@Apellidos, " +
                        "@Correo, " +
                        "@Telefono, " +
                        "@Direccion" +
                        "@Fecha_Nacimiento" +
                        "@ID_Tipo" +
                        "@Fecha_Contrato" +
                        "@Contraseña", conn);
                    cmd.Parameters.AddWithValue("@Cedula_Empleado", p.Cedula_Empleado);
                    cmd.Parameters.AddWithValue("@Nombres", p.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", p.Apellido);
                    cmd.Parameters.AddWithValue("@Correo", p.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", p.Direccion);
                    cmd.Parameters.AddWithValue("@Fecha_Nacimiento", p.Fecha_Nacimiento);
                    cmd.Parameters.AddWithValue("@ID_Tipo", p.ID_Tipo_Empleado);
                    cmd.Parameters.AddWithValue("@Fecha_Contrato", p.Fecha_Contrato);
                    cmd.Parameters.AddWithValue("@Contraseña", p.Contraseña);
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
                    SqlCommand cmd = new SqlCommand("exec pa_EliminarEmpleado" +
                        " @@Cedula_Empleado", conn);
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
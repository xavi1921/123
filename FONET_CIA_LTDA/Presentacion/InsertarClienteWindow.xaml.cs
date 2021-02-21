using Datos.Datos;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FONET_CIA_LTDA.Presentacion
{
    public partial class InsertarClienteWindow : Window
    {
        string cedula = "";
        public InsertarClienteWindow(string ced)
        {
            InitializeComponent();
            if (!ced.Equals(""))
            {
                cedula = ced;
                lblTitulo.Content = "Actualizar";
                VerDatos(ced);
            }
        }
        void VerDatos(string ced)
        {
            Cliente c = ClienteCD.VerCliente(ced);
            txtCedula.Text = c.Cedula;
            txtNombres.Text = c.Nombres;
            txtApellidos.Text = c.Apellidos;
            txtCorreo.Text = c.Correo;
            txtDireccion.Text = c.Direccion;
            txtTelefon.Text = c.Telefono;
            txtCedula.IsReadOnly = true;
        }
        Entidades.Entidades.ClienteFonet CrearObjeto()
        {
            Entidades.Entidades.ClienteFonet c = new Entidades.Entidades.ClienteFonet
            {
                NroContrato = Int32.Parse(txtNrContratoy.Text),
                Cedula = txtCedula.Text,
                Nombres = txtNombres.Text.ToUpper(),
                Apellidos = txtApellidos.Text.ToUpper(),
                Correo = txtCorreo.Text,
                Direccion = txtDireccion.Text.ToUpper(),
                Telefono = txtTelefon.Text.ToUpper(),
                Referencia = txtTelefon.Text.ToUpper(),
                Coordenadas = txtTelefon.Text.ToUpper()
            };
            return c;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (!txtCedula.Text.Equals("") && !txtNombres.Text.Equals("") && !txtApellidos.Text.Equals("") && !txtCorreo.Text.Equals("") && !txtDireccion.Text.Equals("") && !txtTelefon.Text.Equals(""))
            {
                try
                {
                    if (cedula.Equals(""))
                    {
                        //if (Validaciones.VerificarCedula(txtCedula.Text))
                        //{
                            Datos.Datos.ClienteFonet.InsertarClienteF(CrearObjeto());
                            this.Close();
                        //}
                        //else
                        //{
                            //MessageBox.Show("Ingrese una cédula válida");
                            //txtCedula.Focus();
                        //}
                    }
                    else
                    {
                        Datos.Datos.ClienteFonet.Actualizar(CrearObjeto());
                        this.Close();
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingrese los datos correctamente");
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos correctamente");
            }
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //Evita el ingreso de caracteres no numéricos
        private void TxtTelefon_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex restringirEntrada = new Regex("[^0-9]+");
            e.Handled = restringirEntrada.IsMatch(e.Text);
        }

        private void txtCedula_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex restringirEntrada = new Regex("[^0-9]+");
            e.Handled = restringirEntrada.IsMatch(e.Text);
        }
    }
}

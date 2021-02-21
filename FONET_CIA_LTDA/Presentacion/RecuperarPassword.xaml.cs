using Datos.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// <summary>
    /// Lógica de interacción para RecuperarPassword.xaml
    /// </summary>
    public partial class RecuperarPassword : Window
    {
       
        public RecuperarPassword()
        {
            InitializeComponent();
            string ruta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\imagenes\logo.png");
            imgRecuperarPw.Source = new BitmapImage(new Uri(ruta));
        }
        public string recoverPassword(string userRequesting)
        {
            return EmpleadoCD.recuperarPassword(userRequesting);
        }
        private void btnRecuperar_Click(object sender, RoutedEventArgs e)
        {
            if (txtCorreo.Text != "") {
                var men = recoverPassword(txtCorreo.Text);
                lblMensaje.Content = men;
            }
            else
                MessageBox.Show("El campo Solicitado no puede estar vacio");
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

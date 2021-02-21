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
    /// <summary>
    /// Lógica de interacción para InsertarInstalacion.xaml
    /// </summary>
    public partial class InsertarInstalacion : Window
    {
        public InsertarInstalacion(int id)
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void txtCedula_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex restringirEntrada = new Regex("[^0-9]+");
            e.Handled = restringirEntrada.IsMatch(e.Text);
        }

        private void txtObservaciones_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

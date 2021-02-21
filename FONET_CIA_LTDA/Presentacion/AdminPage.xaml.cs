using Datos.Datos;
using Entidades.Entidades;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FONET_CIA_LTDA.Presentacion
{
    /// <summary>
    /// Lógica de interacción para AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        PrincipalWindow main = (PrincipalWindow)Application.Current.Windows[0];
        public AdminPage()
        {
            InitializeComponent();
            CargarDatos();
        }
        void CargarDatos()
        {
            main.cargando.IsOpen = true;
            dtgClientes.ItemsSource = Datos.Datos.ClienteFonet.VerClientes();
            dtgCortes.ItemsSource = Corte_ReconexionCD.VerTodosCortesReconexiones();
            dtgContratos.ItemsSource = Contrato_ServicioCD.VerTodosContratoServicio();
            dtgPagos.ItemsSource = Fecha_PagosCD.VerTodosFechaPago();
            dtgintalacion.ItemsSource = Agendar_InstalacionCD.VerTodasInstalacionesAgendadas();
            dtgPlanMegas.ItemsSource = Tipo_Plan_MegasCD.VerTodosPlanes();
            dtgfacturas.ItemsSource = FacturacionCD.VerTodasFacturaciones();
            dtgUsuarios.ItemsSource = EmpleadoCD.VerEmpleados();
            main.cargando.IsOpen = false;
        }
        private void TabOpciones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tabOpciones.SelectedIndex == 0)
            {
                main.lblTitulo.Content = "ADMINISTRAR CLIENTES";
                btnInsertar.Content = "Nuevo";
            }
            else if (tabOpciones.SelectedIndex == 1)
            {
                main.lblTitulo.Content = "ADMINISTRAR INSTALACIONES";
                btnInsertar.Content = "Agendar";
            }
            else if (tabOpciones.SelectedIndex == 2)
            {
                main.lblTitulo.Content = "ADMINISTRAR CONTRATOS";
                btnInsertar.Content = "Nuevo";
            }
            else if (tabOpciones.SelectedIndex == 3)
            {
                main.lblTitulo.Content = "ADMINISTRAR FECHAS DE PAGO";
                btnInsertar.Content = "Nuevo";
            }
            else if (tabOpciones.SelectedIndex == 4)
            {
                main.lblTitulo.Content = "ADMINISTRAR CORTES Y RECONEXIONES";
                btnInsertar.Content = "Nuevo";
            }
            else if (tabOpciones.SelectedIndex == 5)
            {
                main.lblTitulo.Content = "ADMINISTRAR TIPOS DE PLAN";
                btnInsertar.Content = "Nuevo";
            }
            else if (tabOpciones.SelectedIndex == 6)
            {
                main.lblTitulo.Content = "ADMINISTRAR FACTURAS";
                btnInsertar.Content = "Nuevo";
            }
            else if (tabOpciones.SelectedIndex == 7)
            {
                main.lblTitulo.Content = "ADMINISTRAR USUARIOS (ADMIN)";
                btnInsertar.Content = "Nuevo";
            }

        }
    
        private void BtnInsertar_Click(object sender, RoutedEventArgs e)
        {
            Window insertar = null;

            if (tabOpciones.SelectedIndex == 0)
                insertar = new InsertarClienteWindow("");
            else if (tabOpciones.SelectedIndex == 1)
                insertar = new InsertarInstalacion(-1);
            else if (tabOpciones.SelectedIndex == 2)
                insertar = new InsertarContratoServicio(-1);
            else if (tabOpciones.SelectedIndex == 3)
                insertar = new InsertarFechaPago(-1);
            else if (tabOpciones.SelectedIndex == 4)
                insertar = new InsertarCorteReconexion(-1);
            else if (tabOpciones.SelectedIndex == 5)
                insertar = new InsertarPlanMegas(-1);
            else if (tabOpciones.SelectedIndex == 6)
                insertar = new InsertarFacturas(1);
            else if (tabOpciones.SelectedIndex == 7)
                insertar = new InsertarUsuario("");
            if (insertar != null)
            {
                insertar.ShowDialog();
                CargarDatos();
            }
        }

        private void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            Window actualizar = null;
            if (tabOpciones.SelectedIndex == 0 && dtgClientes.SelectedIndex != -1)
            {
                Cliente p = (Cliente)dtgClientes.Items[dtgClientes.SelectedIndex];
                actualizar = new InsertarClienteWindow(p.Cedula);
            }
            else if (tabOpciones.SelectedIndex == 1 && dtgintalacion.SelectedIndex != -1)
            {
                Agendar_Instalacion c = (Agendar_Instalacion)dtgintalacion.Items[dtgintalacion.SelectedIndex];
                actualizar = new InsertarInstalacion(c.idInstalacion);
            }
            else if (tabOpciones.SelectedIndex == 2 && dtgContratos.SelectedIndex != -1)
            {
                Contrato_Servicio c = (Contrato_Servicio)dtgContratos.Items[dtgContratos.SelectedIndex];
                actualizar = new InsertarContratoServicio(c.IdContrato);
            }
            else if (tabOpciones.SelectedIndex == 3 && dtgPagos.SelectedIndex != -1)
            {
                Fecha_Pagos c = (Fecha_Pagos)dtgPagos.Items[dtgPagos.SelectedIndex];
                actualizar = new InsertarFechaPago(c.IdPago);
            }
            else if (tabOpciones.SelectedIndex == 4 && dtgCortes.SelectedIndex != -1)
            {
                Corte_Reconexion m = (Corte_Reconexion)dtgCortes.Items[dtgCortes.SelectedIndex];
                actualizar = new InsertarCorteReconexion(m.IdCorteReconexion);
            }
            else if (tabOpciones.SelectedIndex == 5 && dtgPlanMegas.SelectedIndex != -1)
            {
                Tipo_Plan_Megas c = (Tipo_Plan_Megas)dtgPlanMegas.Items[dtgPlanMegas.SelectedIndex];
                actualizar = new InsertarPlanMegas(c.IdPlanMegas);
            }
            else if (tabOpciones.SelectedIndex == 6 && dtgfacturas.SelectedIndex != -1)
            {
                Facturacion c = (Facturacion)dtgfacturas.Items[dtgfacturas.SelectedIndex];
                actualizar = new InsertarFacturas(c.idFacturacion);
            }
            else if (tabOpciones.SelectedIndex == 7 && dtgUsuarios.SelectedIndex != -1)
            {
                Empleado c = (Empleado)dtgUsuarios.Items[dtgUsuarios.SelectedIndex];
                actualizar = new InsertarUsuario(c.Cedula_Empleado);
            }
            else
                MessageBox.Show("Seleccione la entidad que desea actualizar");

            if (actualizar != null)
            {
                actualizar.ShowDialog();
                CargarDatos();
            }
        }

        private void Btneliminar_Click(object sender, RoutedEventArgs e)
        {
            msgEliminar.IsOpen = true;
        }
        private void RecargarCargarDatos_Click(object sender, RoutedEventArgs e)
        {
            CargarDatos();
        }

        private void BtnSiEliminar_Click(object sender, RoutedEventArgs e)
        {
            msgEliminar.IsOpen = false;
        }

        private void BtnNoEliminar_Click(object sender, RoutedEventArgs e)
        {
            msgEliminar.IsOpen = false;
        }
    }
}

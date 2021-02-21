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
    /// Lógica de interacción para PrincipalWindow.xaml
    /// </summary>
    public partial class PrincipalWindow : Window
    {
        public PrincipalWindow()
        {
            InitializeComponent();
            //string ruta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\imagenes\Logo icono.png");
            //imgIcon.Source = new BitmapImage(new Uri(ruta));
            //MaxHeight = SystemParameters.VirtualScreenHeight;
            //MaxWidth = SystemParameters.VirtualScreenWidth;
        }
        private void Frame1_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Colse_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;

        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void CerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            salir.IsOpen = true;
        }

        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            salir.IsOpen = false;
            login.Show();
            this.Close();
        }

        private void BtnNoCerrar_Click(object sender, RoutedEventArgs e)
        {
            salir.IsOpen = false;
        }

        /*private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
           if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                WindowStyle = WindowStyle.None;
            }
            else
            {
                //WindowStyle = WindowStyle.SingleBorderWindow;
                
                WindowState = WindowState.Maximized;
                WindowStyle = WindowStyle.None;
            }
            
        }*/
    }
}

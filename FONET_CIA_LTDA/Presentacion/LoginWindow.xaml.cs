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
    /// Lógica de interacción para LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            string ruta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\imagenes\logo.png");
            imgLogin.Source = new BitmapImage(new Uri(ruta));
        }
        private void BtnIngresar_Click_1(object sender, RoutedEventArgs e)
        {
            /*
            string usuario = "0123456789";//txt_Usuario.Text;
            string contraseña = "123";//txt_Clave.Password;
            
               Usuario user = UsuariosCD.Login(usuario, contraseña);
            if (user != null)
            {
                PrincipalWindow main = new PrincipalWindow(user);
                main.Show();
                this.Close();
            }
            else
            {
                errorLogin.IsOpen = true;
                txt_Usuario.Focus();
            }*/

            PrincipalWindow main = new PrincipalWindow();
            main.Show();
            this.Close();
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnError_Click(object sender, RoutedEventArgs e)
        {
            errorLogin.IsOpen = false;
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            RecuperarPassword frmRecuperarPW = new RecuperarPassword();
            frmRecuperarPW.ShowDialog();
        }
    }
}

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
using RetroStoreEsc.Modelos;
using RetroStoreEsc.Servicios;

namespace RetroStoreEsc.Vistas
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        MainWindow pasar;
        public Login(MainWindow mainWindow)
        {
            InitializeComponent();
            pasar = mainWindow;
        }

        private void txtUsuario_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (txtUsuario.Text.Equals("Usuario") || string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.Clear();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtContraseña.Password))
            {
                ServiceUsuarios serviceUsuarios = new ServiceUsuarios();
                Usuarios usuario = serviceUsuarios.SelectId(txtUsuario.Text);

                if (usuario == null)
                {
                    MessageBox.Show("Ingresando...\nEl nombre de usuario no existe");
                }
                else if (usuario.Contraseña == txtContraseña.Password)
                {
                    serviceUsuarios.AbrirSesion(usuario.Id_Usuario);
                    pasar.Contenido.Content = new ViewCategorias(pasar);

                    pasar.btnIniSesion.Visibility = Visibility.Hidden;
                    pasar.btnRegistrarse.Visibility = Visibility.Hidden;
                    pasar.btnCerrarSesion.Visibility = Visibility.Visible;
                }
                else
                {
                    MessageBox.Show("Ingresando...\nContraseña incorrecta");
                }
            }
            else
                MessageBox.Show("Ingresando...\nFaltan datos");
        }
    }
}

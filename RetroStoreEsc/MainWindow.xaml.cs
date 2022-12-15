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
using RetroStoreEsc.Servicios;
using RetroStoreEsc.Modelos;
using RetroStoreEsc.Vistas;

namespace RetroStoreEsc
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            // LlenarBD llenar = new LlenarBD();
            ViewCategorias viewCategorias = new ViewCategorias(this);
            Contenido.Content = viewCategorias;
            OcultarBotones();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Barra.Visibility == Visibility.Visible)
                Barra.Visibility = Visibility.Collapsed;
            else
                Barra.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Contenido.Content = new Registro(this);
            Barra.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ViewCategorias viewCategorias = new ViewCategorias(this);
            Contenido.Content = viewCategorias;
            Barra.Visibility = Visibility.Collapsed;
        }

        private void btnIniSesion_Click(object sender, RoutedEventArgs e)
        {
            Contenido.Content = new Login(this);
            Barra.Visibility = Visibility.Collapsed;
        }

        private void btnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            ServiceUsuarios serviceUsuarios = new ServiceUsuarios();
            Usuarios usuarioActivo = serviceUsuarios.SelectUsuarioActivo();
            serviceUsuarios.CerrarSesion();
            OcultarBotones();
            Barra.Visibility = Visibility.Collapsed;
        }

        private void OcultarBotones()
        {
            ServiceUsuarios serviceUsuarios = new ServiceUsuarios();
            Usuarios usuarioActivo = serviceUsuarios.SelectUsuarioActivo();

            if (usuarioActivo == null)
            {
                btnCerrarSesion.Visibility = Visibility.Collapsed;
                btnRegistrarse.Visibility = Visibility.Visible;
                btnIniSesion.Visibility = Visibility.Visible;
            }
            else
            {
                btnCerrarSesion.Visibility = Visibility.Visible;
                btnRegistrarse.Visibility = Visibility.Hidden;
                btnIniSesion.Visibility = Visibility.Hidden;
            }
        }

        private void btnCarrito_Click(object sender, RoutedEventArgs e)
        {
            Contenido.Content = new Carrito(this);
            Barra.Visibility = Visibility.Collapsed;
        }
    }
}

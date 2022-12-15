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
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : UserControl
    {
        MainWindow pasar;
        public Registro(MainWindow main)
        {
            InitializeComponent();
            pasar = main;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ServiceUsuarios serviceUsuarios = new ServiceUsuarios();

            if (!string.IsNullOrEmpty(txtNombre.Text)
                && !string.IsNullOrEmpty(txtApellidos.Text)
                && !string.IsNullOrEmpty(txtUsuario.Text)
                && !string.IsNullOrEmpty(txtContraseña.Password))
            {
                if (txtNum.Text.Count() > 10)
                {
                    MessageBox.Show("Registrando...\nUn numero de telefono no puede tener mas de 10 digitos, digite un numero valido");
                }
                else
                {
                    Usuarios infousuarios = new Usuarios();

                    infousuarios.Nombre_Cliente = txtNombre.Text;
                    infousuarios.Apellidos = txtApellidos.Text;
                    infousuarios.Usuario = txtUsuario.Text;
                    infousuarios.Contraseña = txtContraseña.Password;
                    infousuarios.No_Telefono = txtNum.Text;
                    infousuarios.Fecha_Nac = Convert.ToDateTime(txtFecha.Text);

                    List<Usuarios> lista = serviceUsuarios.Select();

                    if (serviceUsuarios.Insertar(infousuarios))
                    {
                        pasar.btnIniSesion.Visibility = Visibility.Hidden;
                        pasar.btnRegistrarse.Visibility = Visibility.Hidden;

                        pasar.Contenido.Content = new ViewCategorias(pasar);
                    }
                    
                }
            }
        }

        #region Limpiar TextBoxes

        private void txtNombre_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (txtNombre.Text.Equals("Nombre") || string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.Clear();
            }
        }

        private void txtApellidos_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (txtApellidos.Text.Equals("Apellidos") || string.IsNullOrEmpty(txtApellidos.Text))
            {
                txtApellidos.Clear();
            }
        }

        private void txtUsuario_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (txtUsuario.Text.Equals("Usuario") || string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.Clear();
            }
        }

        private void txtNum_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (txtNum.Text.Equals("Numero de Telefono") || string.IsNullOrEmpty(txtNum.Text))
            {
                txtNum.Clear();
            }
        }

        #endregion
    }
}

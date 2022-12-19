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
                if (QuitarFormatoNum(txtNum.Text).Count() > 10)
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
                    infousuarios.No_Telefono = QuitarFormatoNum(txtNum.Text);
                    infousuarios.Fecha_Nac = Convert.ToDateTime(txtFecha.Text);

                    List<Usuarios> lista = serviceUsuarios.Select();

                    if (serviceUsuarios.Insertar(infousuarios))
                    {
                        pasar.btnIniSesion.Visibility = Visibility.Hidden;
                        pasar.btnRegistrarse.Visibility = Visibility.Hidden;
                        pasar.btnCerrarSesion.Visibility = Visibility.Visible;

                        pasar.Contenido.Content = new ViewCategorias(pasar);
                    }
                    
                }
            }
        }

        #region Limpiar TextBoxes

        private void txtNombre_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            MostrarOcultarEtiquetas(txtNombre, lblNombre, "Nombre");          
        }

        private void txtApellidos_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            MostrarOcultarEtiquetas(txtApellidos, lblApellidos, "Apellidos");
        }

        private void txtUsuario_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            MostrarOcultarEtiquetas(txtUsuario, lblUsuario, "Usuario");
        }

        private void txtNum_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            MostrarOcultarEtiquetas(txtNum, lblNum, "Numero de Telefono");
        }

        private void MostrarOcultarEtiquetas(TextBox textBox, Label label, string str)
        {
            if (textBox.Text.Equals(str))
            {
                textBox.Clear();
                label.Visibility = Visibility.Visible;
            }
            else if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = str;
                label.Visibility = Visibility.Hidden;
            }
        }

        #endregion

        private string QuitarFormatoNum(string f_Num)
        {
            string nf_num = "";

            foreach (char c in f_Num)
            {
                if (!c.Equals('-'))
                    nf_num += c;
            }

            return nf_num;
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            int length = txtNum.Text.Length;

            if ((length == 3 || length == 7) && true)
            {
                txtNum.AppendText("-");
                txtNum.CaretIndex = txtNum.Text.Length;
            }
        }
    }
}

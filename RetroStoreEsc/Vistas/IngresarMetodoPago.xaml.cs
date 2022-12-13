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
    /// Lógica de interacción para IngresarMetodoPago.xaml
    /// </summary>
    public partial class IngresarMetodoPago : UserControl
    {
        MainWindow pasar;
        int backTo;
        public IngresarMetodoPago(MainWindow mainWindow, int cod)
        {
            InitializeComponent();
            pasar = mainWindow;
            backTo = cod;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ServiceUsuarios serviceUsuarios = new ServiceUsuarios();
            Service_Metodo_de_Pago service_Metodo_De_Pago = new Service_Metodo_de_Pago();

            if (!string.IsNullOrWhiteSpace(txtNombre_Titular.Text)
                && !string.IsNullOrWhiteSpace(txtNo_Tarjeta.Text)
                && !string.IsNullOrWhiteSpace(txtClave.Password))
            {
                Metodo_de_Pago metodo_De_Pago = new Metodo_de_Pago();
                metodo_De_Pago.No_Tarjeta = txtNo_Tarjeta.Text;
                metodo_De_Pago.Nombre_Titular = txtNombre_Titular.Text;
                metodo_De_Pago.Fecha_Vencimiento = txtFecha.DisplayDate;
                metodo_De_Pago.Clave = txtClave.Password;
                metodo_De_Pago.Id_Usuario = serviceUsuarios.SelectUsuarioActivo().Id_Usuario;

                service_Metodo_De_Pago.Insertar(metodo_De_Pago);

                if (backTo == 0)
                {
                    pasar.Contenido.Content = new ViewCategorias(pasar);
                }
                else if (backTo == 1)
                {
                    pasar.Contenido.Content = new IngresarDomicilio(pasar);
                }
            }
            else
            {
                MessageBox.Show("Registrando...\nFaltan datos");
            }
        }
    }
}

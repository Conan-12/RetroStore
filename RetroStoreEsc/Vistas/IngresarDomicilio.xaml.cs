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
    /// Lógica de interacción para IngresarDomicilio.xaml
    /// </summary>
    public partial class IngresarDomicilio : UserControl
    {
        MainWindow pasar;
        public IngresarDomicilio(MainWindow mainWindow)
        {
            InitializeComponent();
            pasar = mainWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDireccion.Text)
                && !string.IsNullOrWhiteSpace(txtCP.Text))
            {
                Compra compra = new Compra();

                compra.Direccion_Envio = txtDireccion.Text;
                compra.CP_Envio = Convert.ToInt32(txtCP.Text);
                compra.Fecha_Compra = DateTime.Now;

                pasar.Contenido.Content = new Ticket(pasar, compra);
            }
            else
            {
                MessageBox.Show("Registrando...\nFaltan datos");
            }
        }
    }
}

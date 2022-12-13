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

namespace RetroStoreEsc.Vistas
{
    /// <summary>
    /// Lógica de interacción para ObjetoCategoria.xaml
    /// </summary>
    public partial class ObjetoCategoria : UserControl
    {
        public int id;
        public MainWindow pasar;

        public ObjetoCategoria(MainWindow mainWindow)
        {
            InitializeComponent();
            pasar = mainWindow;
        }

        private void btnCategoria_Click(object sender, RoutedEventArgs e)
        {
            ServiceProductos serviceProductos = new ServiceProductos();
            List<Productos> productos = serviceProductos.SelectCategoria(id);
            pasar.Contenido.Content = new Ventana_Productos_Categoria(productos, pasar);
        }
    }
}

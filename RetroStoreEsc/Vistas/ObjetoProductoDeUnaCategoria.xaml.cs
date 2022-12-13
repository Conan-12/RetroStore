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

namespace RetroStoreEsc.Vistas
{
    /// <summary>
    /// Lógica de interacción para ObjetoProductoDeUnaCategoria.xaml
    /// </summary>
    public partial class ObjetoProductoDeUnaCategoria : UserControl
    {
        public MainWindow pasar;
        public int id_producto;
        List<BitmapImage> recursos;
        public ObjetoProductoDeUnaCategoria(int id, List<BitmapImage> recursosList, MainWindow mainWindow)
        {
            InitializeComponent();
            pasar = mainWindow;
            id_producto = id;
            recursos = recursosList;
        }

        private void btnProducto_Click(object sender, RoutedEventArgs e)
        {
            pasar.Contenido.Content = new ViewProducto(id_producto, recursos);
        }
    }
}

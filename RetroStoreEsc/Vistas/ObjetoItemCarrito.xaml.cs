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
    /// Lógica de interacción para ObjetoItemCarrito.xaml
    /// </summary>
    public partial class ObjetoItemCarrito : UserControl
    {
        public decimal total = 0;
        int idVenta;
        MainWindow pasar;
        public ObjetoItemCarrito(int id_Producto, int cantidad, BitmapImage bitmap, int id_Venta, MainWindow mainWindow)
        {
            InitializeComponent();
            idVenta = id_Venta;
            pasar = mainWindow;

            ServiceProductos serviceProductos = new ServiceProductos();
            Productos producto = serviceProductos.SelectId(id_Producto);

            total = cantidad * producto.Precio;

            picProducto.Source = bitmap;
            txtModelo.Content = "Modelo: " + producto.Modelo;
            txtPrecio.Content = "Precio: $" + producto.Precio;
            txtCantidad.Content = "Cantidad: " + cantidad.ToString();
            txtTotal.Content = "Total: $" + total.ToString();

        }

        private void btnQuitar_Click(object sender, RoutedEventArgs e)
        {
            Service_Detalle_Venta service_Detalle_Venta = new Service_Detalle_Venta();
            service_Detalle_Venta.Borrar(idVenta);
            pasar.Contenido.Content = new Carrito(pasar);
        }
    }
}

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
    /// Lógica de interacción para ViewProducto.xaml
    /// </summary>
    public partial class ViewProducto : UserControl
    {
        int idLocal;
        public ViewProducto(int id, List<BitmapImage> recursosList)
        {
            InitializeComponent();
            idLocal = id;

            ServiceProductos serviceProductos = new ServiceProductos();
            Productos productos = serviceProductos.SelectId(id);

            txtModelo.Content = productos.Modelo;
            txtMarca.Content = productos.Marca;
            txtCaracteristicas.Text = productos.Caracteristicas;
            txtDescripcion.Text = productos.Descripcion;
            txtPrecio.Content = "$" + productos.Precio.ToString();
            picProducto.Source = recursosList[productos.Id_Producto];
            slider.Minimum = 1;
            slider.Maximum = productos.Stock;

            if (productos.Stock == 0)
            {
                slider.IsEnabled = false;
                btnAgregar.IsEnabled = false;
                txtCantidad.Content = "Sin Stock";
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Service_Detalle_Venta service_Detalle_Venta = new Service_Detalle_Venta();
            ServiceUsuarios serviceUsuarios = new ServiceUsuarios();

            List<Detalle_Venta> lista = service_Detalle_Venta.Select();

            Detalle_Venta nuevoItem = new Detalle_Venta();
            Usuarios usuarioActivo = serviceUsuarios.SelectUsuarioActivo();

            nuevoItem.Id_Usuario = usuarioActivo.Id_Usuario;
            nuevoItem.Id_Producto = idLocal;
            nuevoItem.Cantidad = Convert.ToInt32(slider.Value);
            nuevoItem.Id_Compra = 0;

            service_Detalle_Venta.Insertar(nuevoItem);

            MessageBox.Show("Agregando...\nSe han agregado " + Convert.ToInt32(slider.Value).ToString() + " " + txtModelo.Content + " al carrito");
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtCantidad.Content = "Cantidad: " + Convert.ToInt32(slider.Value).ToString();
        }
    }
}

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
    /// Lógica de interacción para Ticket.xaml
    /// </summary>
    public partial class Ticket : UserControl
    {
        MainWindow pasar;
        List<Detalle_Venta> lista = new List<Detalle_Venta>();
        int idCompra;
        public Ticket(MainWindow mainWindow, Compra compra)
        {
            InitializeComponent();
            pasar = mainWindow;
            txtFecha.Content = compra.Fecha_Compra.ToString();

            Service_Detalle_Venta service_Detalle_Venta = new Service_Detalle_Venta();
            ServiceUsuarios serviceUsuarios = new ServiceUsuarios();
            ServiceCompra serviceCompra = new ServiceCompra();

            List<Detalle_Venta> listaDetalleVenta = service_Detalle_Venta.SelectId(0);

            Usuarios usuario = serviceUsuarios.SelectUsuarioActivo();

            foreach (Detalle_Venta venta in listaDetalleVenta)
            {
                if (venta.Id_Usuario == usuario.Id_Usuario)
                {
                    lista.Add(venta);
                }
            }

            listaCompra listaArticulos = new listaCompra(lista);
            contentArticulos.Content = listaArticulos;
            txtTotal.Content = "$" + listaArticulos.totalCompra;



            List<Compra> compras = serviceCompra.Select();

            if (compras.Count == 0)
            {
                idCompra = 1;
            }
            else
            {
                idCompra = compras[compras.Count - 1].Id_Compra + 1;
            }

            compra.Id_Compra = idCompra;
            serviceCompra.Insertar(compra);

            foreach (Detalle_Venta venta in lista)
            {
                venta.Id_Compra = idCompra;
                service_Detalle_Venta.Actualizar(venta);
            }

        }
    }
}

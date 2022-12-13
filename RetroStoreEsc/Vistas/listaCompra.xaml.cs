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
    /// Lógica de interacción para listaCompra.xaml
    /// </summary>
    public partial class listaCompra : UserControl
    {
        List<List<Label>> labels = new List<List<Label>>();
        public decimal totalCompra = 0;
        public listaCompra(List<Detalle_Venta> lista)
        {
            InitializeComponent();
            ServiceProductos serviceProductos = new ServiceProductos();

            for (int i = 0; i < 11; i++)
            {
                labels.Add(new List<Label>());
                for (int j = 0; j < 4; j++)
                {
                    labels[i].Add(new Label());
                }
            }

            labels[0][0] = txt00;
            labels[0][1] = txt10;
            labels[0][2] = txt20;
            labels[0][3] = txt30;

            labels[1][0] = txt01;
            labels[1][1] = txt11;
            labels[1][2] = txt21;
            labels[1][3] = txt31;

            labels[2][0] = txt02;
            labels[2][1] = txt12;
            labels[2][2] = txt22;
            labels[2][3] = txt32;

            labels[3][0] = txt03;
            labels[3][1] = txt13;
            labels[3][2] = txt23;
            labels[3][3] = txt33;

            labels[4][0] = txt04;
            labels[4][1] = txt14;
            labels[4][2] = txt24;
            labels[4][3] = txt34;

            labels[5][0] = txt05;
            labels[5][1] = txt15;
            labels[5][2] = txt25;
            labels[5][3] = txt35;

            labels[6][0] = txt06;
            labels[6][1] = txt16;
            labels[6][2] = txt26;
            labels[6][3] = txt36;

            labels[7][0] = txt07;
            labels[7][1] = txt17;
            labels[7][2] = txt27;
            labels[7][3] = txt37;

            labels[8][0] = txt08;
            labels[8][1] = txt18;
            labels[8][2] = txt28;
            labels[8][3] = txt38;

            labels[9][0] = txt09;
            labels[9][1] = txt19;
            labels[9][2] = txt29;
            labels[9][3] = txt39;

            labels[10][0] = txt010;
            labels[10][1] = txt110;
            labels[10][2] = txt210;
            labels[10][3] = txt310;



            for (int i = 0; i < lista.Count; i++)
            {
                Productos producto = serviceProductos.SelectId(lista[i].Id_Producto);

                labels[i][0].Content = lista[i].Cantidad;
                labels[i][1].Content = producto.Modelo;
                labels[i][2].Content = Convert.ToString(producto.Precio);
                labels[i][3].Content = Convert.ToString(producto.Precio * lista[i].Cantidad);
                totalCompra += producto.Precio * lista[i].Cantidad;

                producto.Stock -= lista[i].Cantidad;
                serviceProductos.Actualizar(producto);
            }

        }
    }
}

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
    /// Lógica de interacción para Buscar2.xaml
    /// </summary>
    public partial class Buscar2 : UserControl
    {
        private ServiceProductos controlEstud = new ServiceProductos();
        public Buscar2()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<ViewProductos> p = controlEstud.SelectAll();
            p = MetodoBuscar(p, txtBuscar.Text);
            ListProduct.ItemsSource = p;
        }

        public List<ViewProductos> MetodoBuscar(List<ViewProductos> getllanta, string search)
        {
            List<ViewProductos> p = new List<ViewProductos>();
            StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase;

            foreach (ViewProductos i in getllanta)
            {
                if (i.modelo.IndexOf(search, stringComparison) >= 0)
                {
                    p.Add(i);
                }
            }
            return p;
        }

        private void txtBuscar_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (txtBuscar.Text.Equals("Buscar") || string.IsNullOrEmpty(txtBuscar.Text))
            {
                txtBuscar.Clear();
            }
        }
    }
}

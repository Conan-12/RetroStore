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
    /// Lógica de interacción para ViewCategorias.xaml
    /// </summary>
    public partial class ViewCategorias : UserControl
    {
        List<ContentControl> contents = new List<ContentControl>();
        List<BitmapImage> recursos = new List<BitmapImage>();
        MainWindow pasar;

        public ViewCategorias(MainWindow mainWindow)
        {
            pasar = mainWindow;
            InitializeComponent();

            contents.Add(categoria1);
            contents.Add(categoria2);
            contents.Add(categoria3);
            contents.Add(categoria4);
            contents.Add(categoria5);
            contents.Add(categoria6);
            contents.Add(categoria7);
            contents.Add(categoria8);
            contents.Add(categoria9);
            contents.Add(categoria10);

            ServiceCategorias serviceCategorias = new ServiceCategorias();
            List<Categorias> categorias = serviceCategorias.Select();            

            for (int i = 0; i < 11; i++) 
            {
                recursos.Add(new BitmapImage());
            }

            foreach (BitmapImage bitmap in recursos) { bitmap.BeginInit(); }

            recursos[0].UriSource = new Uri("..\\..\\Imagenes\\Categorias\\Gabinetes.png", UriKind.Relative);
            recursos[1].UriSource = new Uri("..\\..\\Imagenes\\Categorias\\Gabinetes.png",  UriKind.Relative);
            recursos[2].UriSource = new Uri("..\\..\\Imagenes\\Categorias\\CategoriaTarjetasMadre.png",  UriKind.Relative);
            recursos[3].UriSource = new Uri("..\\..\\Imagenes\\Categorias\\Procesadores.png",  UriKind.Relative);
            recursos[4].UriSource = new Uri("..\\..\\Imagenes\\Categorias\\TarjetasdeVideo.png",  UriKind.Relative);
            recursos[5].UriSource = new Uri("..\\..\\Imagenes\\Categorias\\FuentesdePoder.png",  UriKind.Relative);
            recursos[6].UriSource = new Uri("..\\..\\Imagenes\\Categorias\\MemoriaRAM.png",  UriKind.Relative);
            recursos[7].UriSource = new Uri("..\\..\\Imagenes\\Categorias\\Almacenamiento.png",  UriKind.Relative);
            recursos[8].UriSource = new Uri("..\\..\\Imagenes\\Categorias\\Refrigeracion.png",  UriKind.Relative);
            recursos[9].UriSource = new Uri("..\\..\\Imagenes\\Categorias\\Monitores.png",  UriKind.Relative);
            recursos[10].UriSource = new Uri("..\\..\\Imagenes\\Categorias\\Perifericos.png",  UriKind.Relative);

            foreach (BitmapImage bitmap in recursos) { bitmap.EndInit(); }

            for (int i = 0; i < categorias.Count; i++)
            {
                ObjetoCategoria objetoCategoria = new ObjetoCategoria(pasar);
                objetoCategoria.txtNombreCategotia.Content = categorias[i].Nombre_Categoria;
                objetoCategoria.imagenBtn.Source = recursos[categorias[i].Id_Categoria];
                objetoCategoria.id = categorias[i].Id_Categoria;

                contents[i].Content = objetoCategoria;
            }            
        }
    }
}

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
    /// Lógica de interacción para Carrito.xaml
    /// </summary>
    public partial class Carrito : UserControl
    {
        List<ContentControl> contents = new List<ContentControl>();
        List<BitmapImage> recursos = new List<BitmapImage>();
        MainWindow pasar;
        int j = 0;
        decimal total = 0;
        public Carrito(MainWindow mainWindow)
        {
            InitializeComponent();
            pasar = mainWindow;

            contents.Add(item1);
            contents.Add(item2);
            contents.Add(item3);
            contents.Add(item4);
            contents.Add(item5);
            contents.Add(item6);
            contents.Add(item7);
            contents.Add(item8);
            contents.Add(item9);

            #region ListaImagenes

            for (int i = 0; i < 46; i++)
            {
                recursos.Add(new BitmapImage());
            }

            foreach (BitmapImage bitmap in recursos) { bitmap.BeginInit(); }

            recursos[0].UriSource = new Uri("..\\..\\Imagenes\\Categorias\\Gabinetes.png", UriKind.Relative);
            recursos[1].UriSource = new Uri("..\\..\\Imagenes\\Gabinetes\\GabineteAORUSC300GLASS.png", UriKind.Relative);
            recursos[2].UriSource = new Uri("..\\..\\Imagenes\\Gabinetes\\ThermaltakeDivider300TGARGB.png", UriKind.Relative);
            recursos[3].UriSource = new Uri("..\\..\\Imagenes\\Gabinetes\\AerocoolQuantum.png", UriKind.Relative);
            recursos[4].UriSource = new Uri("..\\..\\Imagenes\\Gabinetes\\YeyianKalt1101.jpg", UriKind.Relative);
            recursos[5].UriSource = new Uri("..\\..\\Imagenes\\Gabinetes\\YeyianArmageddon2200MOD.png", UriKind.Relative);
            recursos[6].UriSource = new Uri("..\\..\\Imagenes\\Gabinetes\\GigabyteC200.png", UriKind.Relative);

            recursos[7].UriSource = new Uri("..\\..\\Imagenes\\Tarjetas Madre\\AORUS_ATX_B450_Elite_V2.png", UriKind.Relative);
            recursos[8].UriSource = new Uri("..\\..\\Imagenes\\Tarjetas Madre\\ASUS_ATX_ROG_STRIX_B550_F_GAMING.png", UriKind.Relative);
            recursos[9].UriSource = new Uri("..\\..\\Imagenes\\Tarjetas Madre\\Gigabyte_ATX_B550_Gaming_X.png", UriKind.Relative);
            recursos[10].UriSource = new Uri("..\\..\\Imagenes\\Tarjetas Madre\\ASUS_ATX_TUF_Gaming_B550_PLUS_WIFI_II.png", UriKind.Relative);
            recursos[11].UriSource = new Uri("..\\..\\Imagenes\\Tarjetas Madre\\MSI_ATX_MPG_B550_GAMING_PLUS.png", UriKind.Relative);

            recursos[12].UriSource = new Uri("..\\..\\Imagenes\\Procesadores\\Intel_Core_i5_10400F.png", UriKind.Relative);
            recursos[13].UriSource = new Uri("..\\..\\Imagenes\\Procesadores\\Intel_Core_i9_12900K_Intel_UHD_Graphics_770.png", UriKind.Relative);
            recursos[14].UriSource = new Uri("..\\..\\Imagenes\\Procesadores\\Intel_Core_i7_12700F.png", UriKind.Relative);
            recursos[15].UriSource = new Uri("..\\..\\Imagenes\\Procesadores\\AMD_Ryzen_5_5600G_con_Graficos_Radeon_7.png", UriKind.Relative);
            recursos[16].UriSource = new Uri("..\\..\\Imagenes\\Procesadores\\AMD_Ryzen_7_5700G.png", UriKind.Relative);
            recursos[17].UriSource = new Uri("..\\..\\Imagenes\\Procesadores\\AMD_Ryzen_5_5600X.png", UriKind.Relative);

            recursos[18].UriSource = new Uri("..\\..\\Imagenes\\Tarjetas de Video\\NVIDIA_GeForce_GT_730_Rev_3.png", UriKind.Relative);
            recursos[19].UriSource = new Uri("..\\..\\Imagenes\\Tarjetas de Video\\ASUS_AMD_Radeon_RX_6600_8GB.png", UriKind.Relative);
            recursos[20].UriSource = new Uri("..\\..\\Imagenes\\Tarjetas de Video\\MSI_NVIDIA_GeForce_GTX_1660_SUPER_VENTUS_XS_OC.png", UriKind.Relative);
            recursos[21].UriSource = new Uri("..\\..\\Imagenes\\Tarjetas de Video\\ASUS_NVIDIA_ROG_Strix_GeForce_RTX_3050_OC_Gaming.png", UriKind.Relative);
            recursos[22].UriSource = new Uri("..\\..\\Imagenes\\Tarjetas de Video\\EVGA_NVIDIA_GeForce_RTX_3090_FTW3_Ultra_Gaming.png", UriKind.Relative);

            recursos[23].UriSource = new Uri("..\\..\\Imagenes\\Fuentes de Poder\\Corsair_Modular_CX750M_80_PLUS_Bronze.png", UriKind.Relative);
            recursos[24].UriSource = new Uri("..\\..\\Imagenes\\Fuentes de Poder\\Gigabyte_P750GM_80_PLUS_Gold.png", UriKind.Relative);
            recursos[25].UriSource = new Uri("..\\..\\Imagenes\\Fuentes de Poder\\Gigabyte_P550B_80_PLUS_Bronze.png", UriKind.Relative);
            recursos[26].UriSource = new Uri("..\\..\\Imagenes\\Fuentes de Poder\\Aerocool_Cylon_700_80_PLUS_Bronze.png", UriKind.Relative);

            recursos[27].UriSource = new Uri("..\\..\\Imagenes\\Memoria RAM\\XPG_Spectrix_D60G_DDR4.png", UriKind.Relative);
            recursos[28].UriSource = new Uri("..\\..\\Imagenes\\Memoria RAM\\Vengeance_RGB_Pro_DDR4.png", UriKind.Relative);
            recursos[29].UriSource = new Uri("..\\..\\Imagenes\\Memoria RAM\\XPG_SPECTRIX_D50_RGB_Tungsten_Grey_DDR4.png", UriKind.Relative);
            recursos[30].UriSource = new Uri("..\\..\\Imagenes\\Memoria RAM\\Trident_z_rgb_ddr4.png", UriKind.Relative);

            recursos[31].UriSource = new Uri("..\\..\\Imagenes\\Almacenamiento\\Disco_Duro_Interno_Seagate_Barracuda_2TB.png", UriKind.Relative);
            recursos[32].UriSource = new Uri("..\\..\\Imagenes\\Almacenamiento\\SSD_Adata_Ultimate_SU630_QLC_3D.png", UriKind.Relative);
            recursos[33].UriSource = new Uri("..\\..\\Imagenes\\Almacenamiento\\SSD_XPG_Spectrix_S40G.png", UriKind.Relative);
            recursos[34].UriSource = new Uri("..\\..\\Imagenes\\Almacenamiento\\SSD_AORUS_RGB.png", UriKind.Relative);

            recursos[35].UriSource = new Uri("..\\..\\Imagenes\\Refrigeracion\\WATERFORCE_X_240.png", UriKind.Relative);
            recursos[36].UriSource = new Uri("..\\..\\Imagenes\\Refrigeracion\\Aerocool_Mirage_L240.png", UriKind.Relative);
            recursos[37].UriSource = new Uri("..\\..\\Imagenes\\Refrigeracion\\Gigabyte_AORUS_ATC800_RGB.jpg", UriKind.Relative);
            recursos[38].UriSource = new Uri("..\\..\\Imagenes\\Refrigeracion\\Disipador_CPU_Vetroo_V5.jpg", UriKind.Relative);

            recursos[39].UriSource = new Uri("..\\..\\Imagenes\\Monitores\\Monitor_Samsung_LF24T350FHLXZX_LED_24.png", UriKind.Relative);
            recursos[40].UriSource = new Uri("..\\..\\Imagenes\\Monitores\\Monitor_Gamer_MSI_Optix_G241_LED.png", UriKind.Relative);
            recursos[41].UriSource = new Uri("..\\..\\Imagenes\\Monitores\\Monitor_Gamer_AORUS_FV43U_LCD_43.png", UriKind.Relative);

            recursos[42].UriSource = new Uri("..\\..\\Imagenes\\Perifericos\\Teclado_Gamer_Corsair_K55_RGB_PRO.png", UriKind.Relative);
            recursos[43].UriSource = new Uri("..\\..\\Imagenes\\Perifericos\\Teclado_Gamer_Ocelot_Gaming_OGMK02_RGB.png", UriKind.Relative);
            recursos[44].UriSource = new Uri("..\\..\\Imagenes\\Perifericos\\Mouse_Gamer_Logitech_Optico_G203_LightSync.png", UriKind.Relative);
            recursos[45].UriSource = new Uri("..\\..\\Imagenes\\Perifericos\\Mouse_Logitech_Optico_M280.png", UriKind.Relative);

            foreach (BitmapImage bitmap in recursos) { bitmap.EndInit(); }

            #endregion

            Service_Detalle_Venta service_Detalle_Venta = new Service_Detalle_Venta();

            List<Detalle_Venta> listaDetalleVenta = service_Detalle_Venta.DetallesVenta_Carrito_UsuarioActivo();

            foreach (Detalle_Venta venta in listaDetalleVenta)
            {
                ObjetoItemCarrito item = new ObjetoItemCarrito(venta.Id_Producto, venta.Cantidad, recursos[venta.Id_Producto], venta.Id_Venta, pasar);
                total += item.total;
                contents[j].Content = item;
                j++;
            }

            txtTotal.Content = "Total: $" + total.ToString();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool usuarioMP = false;
            ServiceUsuarios serviceUsuarios = new ServiceUsuarios();
            Service_Metodo_de_Pago service_Metodo_De_Pago = new Service_Metodo_de_Pago();

            Usuarios usuario = serviceUsuarios.SelectUsuarioActivo();
            List<Metodo_de_Pago> allMP = service_Metodo_De_Pago.Select();

            foreach (Metodo_de_Pago item in allMP)
            {
                if (item.Id_Usuario == usuario.Id_Usuario)
                {
                    usuarioMP = true;
                }
            }

            if (usuarioMP)
            {
                pasar.Contenido.Content = new IngresarDomicilio(pasar);
            }
            else
            {
                pasar.Contenido.Content = new IngresarMetodoPago(pasar, 1);
            }

        }
    }
}

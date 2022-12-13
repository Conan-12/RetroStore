using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroStoreEsc.Modelos
{
    public class Detalle_Venta
    {
        public int Id_Venta { get; set; }
        public int Id_Compra { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad { get; set; }
    }
}

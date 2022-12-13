using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroStoreEsc.Modelos
{
    public class Compra
    {
        public int Id_Compra { get; set; }
        public DateTime Fecha_Compra { get; set; }
        public string Direccion_Envio { get; set; }
        public int CP_Envio { get; set; }
    }
}

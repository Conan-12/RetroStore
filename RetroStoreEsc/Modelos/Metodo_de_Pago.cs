using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroStoreEsc.Modelos
{
    public class Metodo_de_Pago
    {
        public int Id_MetodoPago { get; set; }
        public int Id_Usuario { get; set; }
        public string No_Tarjeta { get; set; }
        public string Nombre_Titular { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
        public string Clave { get; set; }
    }
}

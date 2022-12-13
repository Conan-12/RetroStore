using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroStoreEsc.Modelos
{
    public class Usuarios
    {
        public int Id_Usuario { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Apellidos { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string No_Telefono { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public byte Sesion { get; set; }
    }
}

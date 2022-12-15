using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroStoreEsc.Modelos
{
    public class Sesion_Usuario
    {
        int id_usuario;
        byte sesion;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public byte Sesion { get => sesion; set => sesion = value; }
    }
}

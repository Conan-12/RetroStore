using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroStoreEsc.Modelos
{
    public class Productos
    {
        public int Id_Producto { get; set; }
        public int Id_Categoria { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public string Caracteristicas { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}

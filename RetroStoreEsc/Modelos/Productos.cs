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

    public class ViewProductos
    {

        public int id_Producto;
        public string categoria;
        public string marca;
        public string modelo;
        public string descripcion;
        public string caracteristicas;
        public decimal precio;
        public int stock;
        public int Id_Producto { get => id_Producto; set => id_Producto = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Caracteristicas { get => caracteristicas; set => caracteristicas = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
    }

}

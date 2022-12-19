using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows;
using RetroStoreEsc.Modelos;

namespace RetroStoreEsc.Servicios
{
    public class ServiceProductos
    {
        public string cadenaCnx;
        public MySqlConnection conexion;
        string server = "localhost";
        string database = "RetroStore";
        string user = "root";
        string password = "978607Ale";

        public ServiceProductos()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = "server=" + server + ";database=" + database + ";Uid=" + user + ";pwd=" + password + ";";
        }

        private bool AbrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("No");
                        break;
                    case 1045:
                        MessageBox.Show("No");
                        break;
                }
                return false;
            }
        }

        private bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Insertar(Productos producto)
        {

            if (producto.Caracteristicas.Length > 300)
                producto.Caracteristicas = producto.Caracteristicas.Substring(0, 300);

            try
            {
                if (this.AbrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Productos (id_Categoria, marca, modelo, descripcion, caracteristicas, precio, stock) VALUES (@id_Categoria, @marca, @modelo, @descripcion ,@caracteristicas, @precio, @stock)", conexion);
                    
                    cmd.Parameters.AddWithValue("@id_Categoria", producto.Id_Categoria);
                    cmd.Parameters.AddWithValue("@marca", producto.Marca);
                    cmd.Parameters.AddWithValue("@modelo", producto.Modelo);
                    cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@caracteristicas", producto.Caracteristicas);
                    cmd.Parameters.AddWithValue("@precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@stock", producto.Stock);

                    cmd.ExecuteNonQuery();
                    this.CerrarConexion();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Actualizar(Productos producto)
        {
            try
            {
                if (this.AbrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE Productos SET id_Producto = @id_Producto, id_Categoria = @id_Categoria, marca = @marca, modelo = @modelo, descripcion = @descripcion, caracteristicas = @caracteristicas, precio = @precio, stock = @stock where id_Producto = @id_Producto", conexion);
                    cmd.Parameters.AddWithValue("@id_Producto", producto.Id_Producto);
                    cmd.Parameters.AddWithValue("@id_Categoria", producto.Id_Categoria);
                    cmd.Parameters.AddWithValue("@marca", producto.Marca);
                    cmd.Parameters.AddWithValue("@modelo", producto.Modelo);
                    cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@caracteristicas", producto.Caracteristicas);
                    cmd.Parameters.AddWithValue("@precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@stock", producto.Stock);

                    cmd.ExecuteNonQuery();
                    this.CerrarConexion();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<Productos> Select()
        {
            string query = "SELECT * FROM Productos";
            List<Productos> lista = new List<Productos>();

            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                try
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Productos producto = new Productos();

                        producto.Id_Producto = Convert.ToInt32(dataReader["Id_Producto"]);
                        producto.Id_Categoria = Convert.ToInt32(dataReader["Id_Categoria"]);
                        producto.Marca = Convert.ToString(dataReader["Marca"]);
                        producto.Modelo = Convert.ToString(dataReader["Modelo"]);
                        producto.Descripcion = Convert.ToString(dataReader["Descripcion"]);
                        producto.Caracteristicas = Convert.ToString(dataReader["Caracteristicas"]);
                        producto.Precio = Convert.ToDecimal(dataReader["Precio"]);
                        producto.Stock = Convert.ToInt32(dataReader["Stock"]);

                        lista.Add(producto);
                    }
                    dataReader.Close();
                }
                catch (MySqlException ex1)
                {
                    MessageBox.Show(ex1.Message);
                    return null;
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.StackTrace);
                    MessageBox.Show(ex2.Message);
                    return null;
                }
                this.CerrarConexion();
                return lista;
            }
            else
            {
                return null;
            }
        }

        public List<Productos> SelectCategoria(int id)
        {
            string query = "select * from Productos where Id_Categoria = ";
            query += id.ToString();


            List<Productos> lista = new List<Productos>();
            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                try
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Productos producto = new Productos();

                        producto.Id_Producto = Convert.ToInt32(dataReader["Id_Producto"]);
                        producto.Id_Categoria = Convert.ToInt32(dataReader["Id_Categoria"]);
                        producto.Marca = Convert.ToString(dataReader["Marca"]);
                        producto.Modelo = Convert.ToString(dataReader["Modelo"]);
                        producto.Descripcion = Convert.ToString(dataReader["Descripcion"]);
                        producto.Caracteristicas = Convert.ToString(dataReader["Caracteristicas"]);
                        producto.Precio = Convert.ToDecimal(dataReader["Precio"]);
                        producto.Stock = Convert.ToInt32(dataReader["Stock"]);

                        lista.Add(producto);
                    }
                    dataReader.Close();
                }
                catch (MySqlException ex1)
                {
                    MessageBox.Show(ex1.Message);
                    return null;
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.StackTrace);
                    MessageBox.Show(ex2.Message);
                    return null;
                }
                this.CerrarConexion();
                return lista;
            }
            else
            {
                return null;
            }
        }

        public Productos SelectId(int id)
        {
            string query = "select * from Productos where Id_Producto = ";
            query += id.ToString();

            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                Productos producto = new Productos();

                try
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    dataReader.Read();                

                    producto.Id_Producto = Convert.ToInt32(dataReader["Id_Producto"]);
                    producto.Id_Categoria = Convert.ToInt32(dataReader["Id_Categoria"]);
                    producto.Marca = Convert.ToString(dataReader["Marca"]);
                    producto.Modelo = Convert.ToString(dataReader["Modelo"]);
                    producto.Descripcion = Convert.ToString(dataReader["Descripcion"]);
                    producto.Caracteristicas = Convert.ToString(dataReader["Caracteristicas"]);
                    producto.Precio = Convert.ToDecimal(dataReader["Precio"]);
                    producto.Stock = Convert.ToInt32(dataReader["Stock"]);

                    dataReader.Close();
                }
                catch (MySqlException ex1)
                {
                    MessageBox.Show(ex1.Message);
                    return null;
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.StackTrace);
                    MessageBox.Show(ex2.Message);
                    return null;
                }
                this.CerrarConexion();
                return producto;
            }
            else
            {
                return null;
            }
        }

        public List<ViewProductos> SelectAll()
        {

            string query = "SELECT * FROM productos JOIN categorias " +
                "ON productos.Id_Categoria=categorias.Id_Categoria";

            List<ViewProductos> lista = new List<ViewProductos>();
            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                try
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        ViewProductos producto = new ViewProductos();

                        producto.Id_Producto = Convert.ToInt32(dataReader["Id_Producto"]);
                        producto.Categoria = Convert.ToString(dataReader["Nombre_Categoria"]);
                        producto.Marca = Convert.ToString(dataReader["Marca"]);
                        producto.Modelo = Convert.ToString(dataReader["Modelo"]);
                        producto.Descripcion = Convert.ToString(dataReader["Descripcion"]);
                        producto.Caracteristicas = Convert.ToString(dataReader["Caracteristicas"]);
                        producto.Precio = Convert.ToDecimal(dataReader["Precio"]);
                        producto.Stock = Convert.ToInt32(dataReader["Stock"]);

                        lista.Add(producto);
                    }
                    dataReader.Close();
                }
                catch (MySqlException ex1)
                {
                    MessageBox.Show(ex1.Message);
                    return null;
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.StackTrace);
                    MessageBox.Show(ex2.Message);
                    return null;
                }
                this.CerrarConexion();
                return lista;
            }
            else
            {
                return null;
            }
        }

        public List<string> Buscar(string busqueda)
        {
            string query = "SELECT Modelo FROM Productos WHERE Modelo LIKE '%" +
                busqueda + "%'";
            List<string> lista = new List<string>();

            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                try
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        lista.Add(Convert.ToString(dataReader["Modelo"]));
                    }
                    dataReader.Close();
                }
                catch (MySqlException ex1)
                {
                    MessageBox.Show(ex1.Message);
                    return null;
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.StackTrace);
                    MessageBox.Show(ex2.Message);
                    return null;
                }
                this.CerrarConexion();
                return lista;
            }
            else
            {
                return null;
            }
        }
    }
}

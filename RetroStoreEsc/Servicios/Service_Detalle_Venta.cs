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
    public class Service_Detalle_Venta
    {
        public string cadenaCnx;
        public MySqlConnection conexion;
        string server = "localhost";
        string database = "RetroStore";
        string user = "root";
        string password = "978607Ale";

        public Service_Detalle_Venta()
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

        public bool Insertar(Detalle_Venta detalle_Venta)
        {

            try
            {
                if (this.AbrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Detalle_Venta (id_Compra, id_Producto, cantidad, id_Usuario) VALUES (@id_Compra, @id_Producto, @cantidad, @id_Usuario)", conexion);

                    cmd.Parameters.AddWithValue("@id_Compra", detalle_Venta.Id_Compra);
                    cmd.Parameters.AddWithValue("@id_Producto", detalle_Venta.Id_Producto);
                    cmd.Parameters.AddWithValue("@cantidad", detalle_Venta.Cantidad);
                    cmd.Parameters.AddWithValue("@id_Usuario", detalle_Venta.Id_Usuario);

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

        public bool Actualizar(Detalle_Venta detalle_Venta)
        {
            try
            {
                if (this.AbrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE Detalle_Venta SET id_Venta = @id_Venta, id_Compra = @id_Compra, id_Producto = @id_Producto, cantidad = @cantidad, id_Usuario = @id_Usuario where id_Venta = @id_Venta", conexion);

                    cmd.Parameters.AddWithValue("@id_Venta", detalle_Venta.Id_Venta);
                    cmd.Parameters.AddWithValue("@id_Compra", detalle_Venta.Id_Compra);
                    cmd.Parameters.AddWithValue("@id_Producto", detalle_Venta.Id_Producto);
                    cmd.Parameters.AddWithValue("@cantidad", detalle_Venta.Cantidad);
                    cmd.Parameters.AddWithValue("@id_Usuario", detalle_Venta.Id_Usuario);

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

        public List<Detalle_Venta> Select()
        {
            string query = "SELECT * FROM Detalle_Venta";
            List<Detalle_Venta> lista = new List<Detalle_Venta>();
            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                try
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Detalle_Venta detalle_Venta = new Detalle_Venta();

                        detalle_Venta.Id_Venta = Convert.ToInt32(dataReader["Id_Venta"]);
                        detalle_Venta.Id_Compra = Convert.ToInt32(dataReader["Id_Compra"]);
                        detalle_Venta.Id_Producto = Convert.ToInt32(dataReader["Id_Producto"]);
                        detalle_Venta.Cantidad = Convert.ToInt32(dataReader["Cantidad"]);
                        detalle_Venta.Id_Usuario = Convert.ToInt32(dataReader["Id_Usuario"]);

                        lista.Add(detalle_Venta);
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

        public List<Detalle_Venta> SelectId(int id)
        {
            string query = "select * from Detalle_Venta where Id_Compra = ";
            query += id.ToString();

            List<Detalle_Venta> lista = new List<Detalle_Venta>();
            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                try
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Detalle_Venta detalle_Venta = new Detalle_Venta();

                        detalle_Venta.Id_Venta = Convert.ToInt32(dataReader["Id_Venta"]);
                        detalle_Venta.Id_Compra = Convert.ToInt32(dataReader["Id_Compra"]);
                        detalle_Venta.Id_Producto = Convert.ToInt32(dataReader["Id_Producto"]);
                        detalle_Venta.Cantidad = Convert.ToInt32(dataReader["Cantidad"]);
                        detalle_Venta.Id_Usuario = Convert.ToInt32(dataReader["Id_Usuario"]);

                        lista.Add(detalle_Venta);
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

        public bool Borrar(int id)
        {
            try
            {
                if (this.AbrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM Detalle_Venta WHERE Id_Venta = @id", conexion);
                    cmd.Parameters.AddWithValue("@id", id);
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

    }
}

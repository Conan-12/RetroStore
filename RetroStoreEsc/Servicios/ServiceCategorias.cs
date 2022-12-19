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
    public class ServiceCategorias
    {
        public string cadenaCnx;
        public MySqlConnection conexion;
        string server = "localhost";
        string database = "RetroStore";
        string user = "root";
        string password = "978607Ale";

        public ServiceCategorias()
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

        public bool Insertar(Categorias categoria)
        {
            try
            {
                if (this.AbrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Categorias (nombre_Categoria) VALUES (@nombre_Categoria)", conexion);
                    
                    cmd.Parameters.AddWithValue("@nombre_Categoria", categoria.Nombre_Categoria);
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

        public bool Actualizar(Categorias categoria)
        {
            try
            {
                if (this.AbrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE Categorias SET id_Categoria = @id_Categoria, nombre_Categoria = @nombre_Categoria", conexion);
                    cmd.Parameters.AddWithValue("@id_Categoria", categoria.Id_Categoria);
                    cmd.Parameters.AddWithValue("@nombre_Categoria", categoria.Nombre_Categoria);
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

        public List<Categorias> Select()
        {

            string query = "SELECT * FROM Categorias";
            List<Categorias> lista = new List<Categorias>();

            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                try
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Categorias categoria = new Categorias();
                        categoria.Id_Categoria = Convert.ToInt32(dataReader["Id_Categoria"]);
                        categoria.Nombre_Categoria = Convert.ToString(dataReader["Nombre_Categoria"]);
                        lista.Add(categoria);
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
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM Categorias WHERE Id_Categoria = @id", conexion);
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

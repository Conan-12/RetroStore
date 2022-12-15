using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;
using RetroStoreEsc.Modelos;


namespace RetroStoreEsc.Servicios
{
    public class Service_Sesion_Usuario
    {
        public string cadenaCnx;
        public MySqlConnection conexion;
        string server = "localhost";
        string database = "PlanTech";
        string user = "root";
        string password = "978607Ale";

        public Service_Sesion_Usuario()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = "server=" + server + ";database=" + database + ";Uid=" + user + ";pwd=" + password + ";";
        }

        private bool AbrirConexion()
        {
            try
            {
                CerrarConexion();
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

        public bool Insertar(Sesion_Usuario usuario)
        {
            try
            {
                if (this.AbrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Sesion_Usuario (sesion) VALUES (@sesion)", conexion);

                    cmd.Parameters.AddWithValue("@nom_Usuario", usuario.Sesion);

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

        public bool Actualizar(Sesion_Usuario usuario)
        {
            try
            {
                if (this.AbrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE Usuario SET id_Usuario = @id_Usuario, sesion = @sesion where id_Usuario = @id_Usuario", conexion);

                    cmd.Parameters.AddWithValue("@id_Usuario", usuario.Id_usuario);
                    cmd.Parameters.AddWithValue("@sesion", usuario.Sesion);

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

        public Sesion_Usuario SelectId(int id)
        {
            string query = "select * from Sesion_Usuario where id_usuario = '";
            query += id + "'";
            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                Sesion_Usuario usuario = new Sesion_Usuario();
                try
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();

                    usuario.Id_usuario = Convert.ToInt32(dataReader["id_Usuario"]);
                    usuario.Sesion = Convert.ToByte(dataReader["sesion"]);

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
                return usuario;
            }
            else
            {
                return null;
            }
        }

        public List<Sesion_Usuario> Select()
        {
            string query = "SELECT * FROM Sesion_Usuario";
            List<Sesion_Usuario> lista = new List<Sesion_Usuario>();
            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                try
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Sesion_Usuario usuario = new Sesion_Usuario();

                        usuario.Id_usuario = Convert.ToInt32(dataReader["id_usuario"]);
                        usuario.Sesion = Convert.ToByte(dataReader["sesion"]);

                        lista.Add(usuario);
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

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
    public class ServiceCompra
    {
        public string cadenaCnx;
        public MySqlConnection conexion;
        string server = "localhost";
        string database = "RetroStore";
        string user = "root";
        string password = "978607Ale";

        public ServiceCompra()
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

        public bool Insertar(Compra compra)
        {
            try
            {
                if (this.AbrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Compra (fecha_Compra, direccion_Envio, cP_Envio) VALUES (@fecha_Compra, @direccion_Envio, @cP_Envio)", conexion);

                    cmd.Parameters.AddWithValue("@fecha_Compra", compra.Fecha_Compra);
                    cmd.Parameters.AddWithValue("@direccion_Envio", compra.Direccion_Envio);
                    cmd.Parameters.AddWithValue("@cP_Envio", compra.CP_Envio);

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

        public bool Actualizar(Compra compra)
        {
            try
            {
                if (this.AbrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE Compra SET id_Compra = @id_Compra, fecha_Compra = @fecha_Compra, direccion_Envio = @direccion_Envio, cP_Envio = @cP_Envio", conexion);

                    cmd.Parameters.AddWithValue("@id_Compra", compra.Id_Compra);
                    cmd.Parameters.AddWithValue("@fecha_Compra", compra.Fecha_Compra);
                    cmd.Parameters.AddWithValue("@direccion_Envio", compra.Direccion_Envio);
                    cmd.Parameters.AddWithValue("@cP_Envio", compra.CP_Envio);

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

        public List<Compra> Select()
        {
            string query = "SELECT * FROM Compra";
            List<Compra> lista = new List<Compra>();
            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                try
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Compra compra = new Compra();

                        compra.Id_Compra = Convert.ToInt32(dataReader["Id_Compra"]);
                        compra.Fecha_Compra = Convert.ToDateTime(dataReader["Fecha_Compra"]);
                        compra.Direccion_Envio = Convert.ToString(dataReader["Direccion_Envio"]);
                        compra.CP_Envio = Convert.ToInt32(dataReader["CP_Envio"]);

                        lista.Add(compra);
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

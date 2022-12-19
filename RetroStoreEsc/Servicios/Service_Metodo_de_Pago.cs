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
    public class Service_Metodo_de_Pago
    {
        public string cadenaCnx;
        public MySqlConnection conexion;
        string server = "localhost";
        string database = "RetroStore";
        string user = "root";
        string password = "978607Ale";

        public Service_Metodo_de_Pago()
        {
            conexion = new MySqlConnection();

            conexion.ConnectionString = "server=" + server + ";database="
                + database + ";Uid=" + user + ";pwd=" + password + ";";

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

        public bool Insertar(Metodo_de_Pago metodo_De_Pago)
        {

            try
            {
                if (this.AbrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Metodo_de_Pago (no_Tarjeta, id_Usuario, nombre_Titular, fecha_Vencimiento, clave) VALUES (@no_Tarjeta, @id_Usuario, @nombre_Titular, @fecha_Vencimiento, @clave)", conexion);

                    cmd.Parameters.AddWithValue("@no_Tarjeta", metodo_De_Pago.No_Tarjeta);
                    cmd.Parameters.AddWithValue("@id_Usuario", metodo_De_Pago.Id_Usuario);
                    cmd.Parameters.AddWithValue("@nombre_Titular", metodo_De_Pago.Nombre_Titular);
                    cmd.Parameters.AddWithValue("@fecha_Vencimiento", metodo_De_Pago.Fecha_Vencimiento);
                    cmd.Parameters.AddWithValue("@clave", metodo_De_Pago.Clave);

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

        public bool Actualizar(Metodo_de_Pago metodo_De_Pago)
        {
            try
            {
                if (this.AbrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE Metodo_de_Pago SET id_MetodoPago = @id_MetodoPago, no_Tarjeta = @no_Tarjeta, id_Usuario = @id_Usuario, nombre_Titular = @nombre_Titular, fecha_Vencimiento = @fecha_Vencimiento, clave = @clave", conexion);

                    cmd.Parameters.AddWithValue("@id_MetodoPago", metodo_De_Pago.Id_MetodoPago);
                    cmd.Parameters.AddWithValue("@no_Tarjeta", metodo_De_Pago.No_Tarjeta);
                    cmd.Parameters.AddWithValue("@id_Usuario", metodo_De_Pago.Id_Usuario);
                    cmd.Parameters.AddWithValue("@nombre_Titular", metodo_De_Pago.Nombre_Titular);
                    cmd.Parameters.AddWithValue("@fecha_Vencimiento", metodo_De_Pago.Fecha_Vencimiento);
                    cmd.Parameters.AddWithValue("@clave", metodo_De_Pago.Clave);

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

        public List<Metodo_de_Pago> Select()
        {
            string query = "SELECT * FROM Metodo_de_Pago";
            List<Metodo_de_Pago> lista = new List<Metodo_de_Pago>();

            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                try
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Metodo_de_Pago metodo_De_Pago = new Metodo_de_Pago();

                        metodo_De_Pago.Id_MetodoPago = Convert.ToInt32(dataReader["Id_MetodoPago"]);
                        metodo_De_Pago.No_Tarjeta = Convert.ToString(dataReader["No_Tarjeta"]);
                        metodo_De_Pago.Id_Usuario = Convert.ToInt32(dataReader["Id_Usuario"]);
                        metodo_De_Pago.Nombre_Titular = Convert.ToString(dataReader["Nombre_Titular"]);
                        metodo_De_Pago.Fecha_Vencimiento = Convert.ToDateTime(dataReader["Fecha_Vencimiento"]);
                        metodo_De_Pago.Clave = Convert.ToString(dataReader["Clave"]);

                        lista.Add(metodo_De_Pago);
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

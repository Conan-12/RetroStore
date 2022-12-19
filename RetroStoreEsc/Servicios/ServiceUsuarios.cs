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
    public class ServiceUsuarios
    {
        public string cadenaCnx;
        public MySqlConnection conexion;
        string server = "localhost";
        string database = "RetroStore";
        string user = "root";
        string password = "978607Ale";

        public ServiceUsuarios()
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

        public bool Insertar(Usuarios usuario)
        {
            try
            {
                if (this.AbrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Usuarios (nombre_Cliente, apellidos, usuario, contraseña, no_Telefono, fecha_Nac) VALUES (@nombre_Cliente, @apellidos, @usuario, @contraseña, @no_Telefono, @fecha_Nac)", conexion);

                    cmd.Parameters.AddWithValue("@nombre_Cliente", usuario.Nombre_Cliente);
                    cmd.Parameters.AddWithValue("@apellidos", usuario.Apellidos);
                    cmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
                    cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                    cmd.Parameters.AddWithValue("@no_Telefono", usuario.No_Telefono);
                    cmd.Parameters.AddWithValue("@fecha_Nac", usuario.Fecha_Nac);

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

        public bool Actualizar(Usuarios usuario)
        {
            try
            {
                if (this.AbrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE Usuarios SET id_Usuario = @id_Usuario, nombre_Cliente = @nombre_Cliente, apellidos = @apellidos, usuario = @usuario, contraseña = @contraseña, no_Telefono = @no_Telefono, fecha_Nac = @fecha_Nac, sesion = @sesion where id_Usuario = @id_Usuario", conexion);

                    cmd.Parameters.AddWithValue("@id_Usuario", usuario.Id_Usuario);
                    cmd.Parameters.AddWithValue("@nombre_Cliente", usuario.Nombre_Cliente);
                    cmd.Parameters.AddWithValue("@apellidos", usuario.Apellidos);
                    cmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
                    cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                    cmd.Parameters.AddWithValue("@no_Telefono", usuario.No_Telefono);
                    cmd.Parameters.AddWithValue("@fecha_Nac", usuario.Fecha_Nac);

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

        public Usuarios SelectId(string userName)
        {
            string query = "select * from Usuarios where Usuario = '";
            query += userName + "'";

            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                Usuarios usuario = new Usuarios();
                try
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();

                    usuario.Id_Usuario = Convert.ToInt32(dataReader["Id_Usuario"]);
                    usuario.Nombre_Cliente = Convert.ToString(dataReader["Nombre_Cliente"]);
                    usuario.Apellidos = Convert.ToString(dataReader["Apellidos"]);
                    usuario.Usuario = Convert.ToString(dataReader["Usuario"]);
                    usuario.Contraseña = Convert.ToString(dataReader["Contraseña"]);
                    usuario.No_Telefono = Convert.ToString(dataReader["No_Telefono"]);
                    usuario.Fecha_Nac = Convert.ToDateTime(dataReader["Fecha_Nac"]);

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

        public Usuarios SelectUsuarioActivo()
        {
            string query = "select Usuarios.Id_Usuario, Nombre_Cliente, Apellidos," +
                "Usuario, Contraseña, No_Telefono, Fecha_Nac from Usuarios," +
                "Sesion_Usuario where Sesion = 1";

            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                Usuarios usuario = new Usuarios();

                try
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();

                    usuario.Id_Usuario = Convert.ToInt32(dataReader["Id_Usuario"]);
                    usuario.Nombre_Cliente = Convert.ToString(dataReader["Nombre_Cliente"]);
                    usuario.Apellidos = Convert.ToString(dataReader["Apellidos"]);
                    usuario.Usuario = Convert.ToString(dataReader["Usuario"]);
                    usuario.Contraseña = Convert.ToString(dataReader["Contraseña"]);
                    usuario.No_Telefono = Convert.ToString(dataReader["No_Telefono"]);
                    usuario.Fecha_Nac = Convert.ToDateTime(dataReader["Fecha_Nac"]);

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

        public List<Usuarios> Select()
        {
            string query = "SELECT * FROM Usuarios";
            List<Usuarios> lista = new List<Usuarios>();

            if (this.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                try
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Usuarios usuario = new Usuarios();

                        usuario.Id_Usuario = Convert.ToInt32(dataReader["Id_Usuario"]);
                        usuario.Nombre_Cliente = Convert.ToString(dataReader["Nombre_Cliente"]);
                        usuario.Apellidos = Convert.ToString(dataReader["Apellidos"]);
                        usuario.Usuario = Convert.ToString(dataReader["Usuario"]);
                        usuario.Contraseña = Convert.ToString(dataReader["Contraseña"]);
                        usuario.No_Telefono = Convert.ToString(dataReader["No_Telefono"]);
                        usuario.Fecha_Nac = Convert.ToDateTime(dataReader["Fecha_Nac"]);

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

        public void CerrarSesion()
        {
            try
            {
                if (this.AbrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("call cerrar_sesion();", conexion);

                    cmd.ExecuteNonQuery();
                    this.CerrarConexion();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AbrirSesion(int id)
        {
            try
            {
                if (this.AbrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("call iniciar_sesion(" +
                        id.ToString() + ");", conexion);

                    cmd.ExecuteNonQuery();
                    this.CerrarConexion();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

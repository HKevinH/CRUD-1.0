using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_SGBD
{
    public class ConexionMySQL
    {
        private MySqlConnection connection;
        public string Server { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }
        public static string ConnectionString
        {
            get
            {
                return $"Server={Conex.server};Port={Conex.port};Database={Conex.database};Uid={Conex.username};Pwd={Conex.password};SslMode=none;";
            }
        }
        public ConexionMySQL(string server, string port, string username, string password, string database)
        {
            this.Server = server;
            this.Port = port;
            this.Username = username;
            this.Password = password;
            this.Database = database;

            string connectionString = $"Server={Server};Port={Port};Database={Database};Uid={Username};Pwd={Password};";
            connection = new MySqlConnection(connectionString);
        }

        public void Open()
        {
            connection.Open();
        }

        public void Close()
        {
            connection.Close();
        }
        public ConnectionState State
        {
            get { return connection.State; }
        }
        //

        public DataTable GetTabla(string tabla)
        {
            string query = $"SELECT * FROM {tabla};";
            using (var conexion = new MySqlConnection(ConexionMySQL.ConnectionString))
            {
                var dataAdapter = new MySqlDataAdapter(query, conexion);

                var command = new MySqlCommand(query, conexion);
                command.CommandType = CommandType.Text;
                dataAdapter.SelectCommand = command;

                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                return dataTable;
                // Do something with the data in the DataTable...
            }
        }

        public int GetTablaPersonaje(int idUsuario)
        {
            string query = $"SELECT IdPersonaje FROM personaje WHERE Usuario = '{idUsuario}';";
            using (var conexion = new MySqlConnection(ConexionMySQL.ConnectionString))
            {
                var command = new MySqlCommand(query, conexion);
                conexion.Open();
                var idPersonajeObject = command.ExecuteScalar();
                conexion.Close();

                int idPersonaje;
                if (idPersonajeObject != null && int.TryParse(idPersonajeObject.ToString(), out idPersonaje))
                {
                    MessageBox.Show($"El id del personaje es {idPersonaje}");
                    return idPersonaje;
                }
                else
                {
                    MessageBox.Show($"No se encontró ningún personaje para el usuario con ID {idUsuario}");
                    return 0;
                }
            }
        }

        public DataTable GetTablaClass(string tabla)
        {
            string query = $"SELECT * FROM {tabla};";
            using (var conexion = new MySqlConnection(ConexionMySQL.ConnectionString))
            {
                var dataAdapter = new MySqlDataAdapter(query, conexion);

                var command = new MySqlCommand(query, conexion);
                command.CommandType = CommandType.Text;
                dataAdapter.SelectCommand = command;

                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Agregar una columna de iconos para la tabla de guerreros
                if (dataTable.Columns.Contains("Clase"))
                {
                    dataTable.Columns.Add(new DataColumn("Icon", typeof(Image)));

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string clase = row["Clase"].ToString();

                        switch (clase)
                        {
                            case "Guerrero":
                                row["Icon"] = Properties.Resources.class_warrior; // cambia el icono por el que desees
                                break;
                            case "Mago":
                                row["Icon"] = Properties.Resources.class_mage; // cambia el icono por el que desees
                                break;
                            case "Arquero":
                                row["Icon"] = Properties.Resources.classes_hunter; // cambia el icono por el que desees
                                break;
                            case "Ladrón":
                                row["Icon"] = Properties.Resources.classes_rogue; // cambia el icono por el que desees
                                break;
                        }
                    }
                }


                return dataTable;
                // Do something with the data in the DataTable...
            }
        }

        public void UpdateUsuario(int IdUsuario, string usuario, string nombre,string nuevoCorreo, string contraseña)
        {
            string query = $"UPDATE Usuario SET Usuario='{usuario}', Nombre='{nombre}', Correo='{nuevoCorreo}', Contra='{contraseña}' WHERE IdUsuario={IdUsuario};";
            using (MySqlConnection connection = new MySqlConnection(ConexionMySQL.ConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("Usuario", usuario);
                command.Parameters.AddWithValue("Nombre", nombre);
                command.Parameters.AddWithValue("Correo", nuevoCorreo);
                command.Parameters.AddWithValue("Contraseña", contraseña);
                command.Parameters.AddWithValue("IdUsuario", IdUsuario);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public class SqlQueriesInf
    {
        private UIUsuariosView _uIUsuariosView;


        public SqlQueriesInf()
        {
            _uIUsuariosView = new UIUsuariosView();
        }
        public void DeleteFrom(DataGridView dataGridView, string nombreTabla)
        {
            if (dataGridView.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["IdUsuario"].Value); // Reemplaza "IdUsuario" con el nombre de la columna que contiene el ID en tu DataGridView
                string query = "DELETE FROM " + nombreTabla + " WHERE IdUsuario = @IdUsuario";
                using (var conexion = new MySqlConnection(ConexionMySQL.ConnectionString))
                {
                    conexion.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@IdUsuario", id);
                    cmd.ExecuteNonQuery();
                }
                dataGridView.Rows.Remove(dataGridView.CurrentRow);
            }
        }

        public void DeleteFromPersonaje(int idUsuario)
        {
            string query = "DELETE FROM Personaje WHERE Usuario = @IdUsuario";
            using (MySqlConnection connection = new MySqlConnection(ConexionMySQL.ConnectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void DeleteTomarMision(int idPersonaje)
        {
            string query = "DELETE FROM tomar_mision WHERE IdPersonaje = @IdPersonaje";
            using (MySqlConnection connection = new MySqlConnection(ConexionMySQL.ConnectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@IdPersonaje", idPersonaje);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void SearcherSQL(System.Windows.Forms.ComboBox comboBox)
        {
            try
            {
                // Establecer la conexión a la base de datos
                using (MySqlConnection connection = new MySqlConnection(ConexionMySQL.ConnectionString))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Ejecutar la consulta
                    MySqlCommand command = new MySqlCommand("SHOW TABLES", connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    // Agregar los nombres de las tablas al ComboBox
                    while (reader.Read())
                    {
                        string tableName = reader.GetString(0);
                        comboBox.Items.Add(tableName);
                    }


                    // Cerrar el lector y la conexión
                    reader.Close();
                    connection.Close();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public class UsuariosDelete : SqlQueriesInf
        {
            public void EliminarRegistro(DataGridView dataGridView, string nombreTabla)
            {
                DeleteFrom(dataGridView, nombreTabla);
            }
        }
    }
}

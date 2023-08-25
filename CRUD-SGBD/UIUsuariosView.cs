using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static CRUD_SGBD.Conex;
using static CRUD_SGBD.SqlQueriesInf;

namespace CRUD_SGBD
{
    public partial class UIUsuariosView : Form
    {
        public UIUsuariosView()
        {
            InitializeComponent();
            dataUserList.CellEndEdit += dataUserList_CellEndEdit;
            // Suscribirse al evento RowLeave del DataGridView
            //dataUserList.RowLeave += dataGridView1_RowLeave;
            dataUserList.KeyDown += new KeyEventHandler(dataUserList_KeyDown);
            dataUserList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void UIUsuariosView_Load(object sender, EventArgs e)
        {
            var dataService = new ConexionMySQL(Conex.server, Conex.port, Conex.database, Conex.username, Conex.password);

            var bindingSource = new BindingSource();
            var dataTable = dataService.GetTabla("Usuario");
            bindingSource.DataSource = dataTable;
            dataUserList.DataSource = bindingSource;
            dataUserList.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            dataUserList.AllowUserToAddRows = true;
            dataUserList.AllowUserToDeleteRows = true;
            dataUserList.ReadOnly = false;

        }

        private void dataUserList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dataUserList.CurrentCell.ColumnIndex == dataUserList.Columns.Count - 1)
            {
                // Verifica que la fila no sea una fila nueva
                if (!dataUserList.Rows[dataUserList.CurrentCell.RowIndex].IsNewRow)
                {
                    DataGridViewRow row = dataUserList.Rows[dataUserList.CurrentCell.RowIndex];

                    // Obtiene los valores de las celdas de la fila
                    int idUsuario;
                    int.TryParse(row.Cells["IdUsuario"].Value?.ToString(), out idUsuario);
                    string usuario = row.Cells["Usuario"].Value?.ToString();
                    string nombre = row.Cells["Nombre"].Value?.ToString();
                    string correo = row.Cells["Correo"].Value?.ToString();
                    string contra = row.Cells["Contra"].Value?.ToString();

                    // Verifica que los valores de las celdas no sean nulos o vacíos
                    if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(nombre) &&
                        !string.IsNullOrEmpty(correo) && !string.IsNullOrEmpty(contra))
                    {
                        // Realiza la inserción en la base de datos
                        string query = $"INSERT INTO Usuario(IdUsuario, Usuario, Nombre, Correo, Contra) VALUES ({idUsuario}, '{usuario}', '{nombre}', '{correo}', '{contra}')";
                        using (var connection = new MySqlConnection(ConexionMySQL.ConnectionString))
                        {
                            connection.Open();
                            var command = new MySqlCommand(query, connection);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public DataTable Usuarios() 
        {
            string query = "SELECT * FROM Usuario;";
            string connectionString = $"Server={Conex.server};Port={Conex.port};Database={Conex.database};Uid={Conex.username};Pwd={Conex.password};SslMode=none;";

            using (var conexion = new MySqlConnection(connectionString))
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataUserList.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow row = dataUserList.Rows[e.RowIndex];
                int idUsuario;
                int.TryParse(row.Cells["IdUsuario"].Value?.ToString(), out idUsuario);
                string usuario = row.Cells["Usuario"].Value?.ToString();
                string nombre = row.Cells["Nombre"].Value?.ToString();
                string correo = row.Cells["Correo"].Value?.ToString();
                string contra = row.Cells["Contra"].Value?.ToString();

                // Verifica que los valores de las celdas no sean nulos o vacíos
                if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(nombre) &&
                    !string.IsNullOrEmpty(correo) && !string.IsNullOrEmpty(contra))
                {
                    // Realiza la inserción en la base de datos
                    string query = $"INSERT INTO Usuario(IdUsuario, Usuario, Nombre, Correo, Contraseña) VALUES ({idUsuario}, '{usuario}', '{nombre}', '{correo}', '{contra}')";
                    using (var connection = new MySqlConnection(ConexionMySQL.ConnectionString))
                    {
                        connection.Open();
                        var command = new MySqlCommand(query, connection);
                        command.ExecuteNonQuery();
                    }
                }
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
        }

        public void DeleteSelectedRow(DataGridView dataGridView)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView.Rows[rowIndex];

                int id = Convert.ToInt32(selectedRow.Cells["IdUsuario"].Value);
                var dataService = new ConexionMySQL(Conex.server, Conex.port, Conex.database, Conex.username, Conex.password);
                int idPersonaje = dataService.GetTablaPersonaje(id);

                if (idPersonaje != 0)
                {
                    UsuariosDelete usuariosDelete = new UsuariosDelete();
                    usuariosDelete.DeleteTomarMision(idPersonaje);
                    usuariosDelete.DeleteFromPersonaje(id);
                    dataGridView.Rows.Remove(selectedRow);
                }
                else
                {
                    MessageBox.Show("Error!!");
                }
            }
            else
            {
                MessageBox.Show("No hay filas seleccionadas.");
            }
        }


        private void dataUserList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataUserList.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells["IdUsuario"].Value);
            var usuario = row.Cells["Usuario"].Value.ToString();
            var nombre = row.Cells["Nombre"].Value.ToString();
            var correo = row.Cells["Correo"].Value.ToString();
            var contraseña = row.Cells["Contra"].Value.ToString();

            var dataService = new ConexionMySQL(Conex.server, Conex.port, Conex.database, Conex.username, Conex.password);
            dataService.UpdateUsuario(id, usuario, nombre, correo, contraseña);

            // Verifica que se haya editado la última celda de la fila
            if (e.ColumnIndex == dataUserList.Columns.Count - 1)
            {
                // Guarda los datos de la fila
                dataUserList.EndEdit();
            }
        }

        public DataGridView DataUserList
        {
            get { return dataUserList; }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DeleteSelectedRow(dataUserList);
        }
    }

}



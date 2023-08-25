using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using WinFormsButton = System.Windows.Forms.Button;

namespace CRUD_SGBD
{
        public partial class Conex : Form
    {

        public static string server;
        public static string port;
        public static string username;
        public static string password;
        public static string database;
        public static string conectionString;

        public Conex()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor = new Cursor("../../Resources/arrow.cur");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            server = textServer.Text; // o la dirección IP del servidor MySQL
            port = textPort.Text; // o el número de puerto en el que se ejecuta MySQL
            username = textUser.Text;
            password = textPass.Text;
            database = textDatabase.Text;

            ConexionMySQL conexion = new ConexionMySQL(server, port, username, password, database);
            try
            {
                conexion.Open();
                if (conexion.State == ConnectionState.Open)
                {
                    MessageBox.Show("Conexión exitosa");
                    Home homeForm = new Home();
                    homeForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se pudo conectar a la base de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}");
            }
            finally
            {
                conexion.Close();
            }

        }

        private void textServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textDatabase_TextChanged(object sender, EventArgs e)
        {
        }
    }


}

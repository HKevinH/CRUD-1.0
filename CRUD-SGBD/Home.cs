using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static CRUD_SGBD.Home;

namespace CRUD_SGBD
{
    public partial class Home : Form
    {
        private Timer timer1;
        private string server;
        private string port;
        private string username;
        private string password;
        private string database;
        private string conectionString;
        private DataGridView dataUserHijo;
        private UIUsuariosView uiUsuariosView;
        private UIPersonajeView uiPersonajeView;
        public Home(string server, string port, string username, string password, string database, string conectionString)
        {
            InitializeComponent();
            this.server = server;
            this.port = port;
            this.username = username;
            this.password = password;
            this.database = database;
            this.conectionString = conectionString;
        }
        public Home()
        {
            InitializeComponent();

            CustomerDesing();
            // Inicializa el temporizador
            timer1 = new Timer();
            timer1.Interval = 1000; // 1 segundo
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            uiUsuariosView = new UIUsuariosView();

        }

        #region
        private void CustomerDesing()
        {
            panelSubmenu.Visible = false;
            Cursor = new Cursor("../../Resources/arrow.cur");
        }
        private void showMenu()
        {
            if (panelSubmenu.Visible == false)
            {
                panelSubmenu.Visible = true;
            }
            else
            {
                panelSubmenu.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new NewsHome());
            if (activeForm.GetType() == typeof(UISearcher))
            {
                btnSearch.Visible = true;
                Debug.WriteLine("Mostrando botón de búsqueda.");

            }
            else
            {
                btnSearch.Visible = false;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Media_Click(object sender, EventArgs e)
        {
            showMenu();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UIUsuariosView());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UIPersonajeView());
        }
        private void logo_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panelChild_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panelChild_load(object sender, EventArgs e)
        {
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm == null)
            {
                activeForm = childForm;
                activeForm.TopLevel = false;
                activeForm.FormBorderStyle = FormBorderStyle.None;
                activeForm.Dock = DockStyle.Fill;
                panelChild.Controls.Add(activeForm);
                panelChild.Tag = activeForm;
                activeForm.BringToFront();
                activeForm.Show();
            }
            else if (activeForm.GetType() == childForm.GetType())
            {
                // No hacer nada, ya que el formulario ya está abierto
            }
            else
            {
                activeForm.Close(); // Cerrar el formulario actualmente abierto
                activeForm = childForm;
                activeForm.TopLevel = false;
                activeForm.FormBorderStyle = FormBorderStyle.None;
                activeForm.Dock = DockStyle.Fill;
                panelChild.Controls.Add(activeForm);
                panelChild.Tag = activeForm;
                activeForm.BringToFront();
                activeForm.Show();
            }
            if (activeForm.GetType() == typeof(UISearcher))
            {
                btnSearch.Visible = true;
            }
            else
            {
                btnSearch.Visible = false;
            }
        }
        #endregion

        #region
        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UICreatureMisionesView());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UINpcView());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UIMisionesView());
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new UIMisionesTomadasView());

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Actualiza el contenido del Label con la hora actual
            time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(activeForm !=  null)
                activeForm.Close();
            OpenChildForm(new UISearcher());
        }
        private void panelContenedorT_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panelAnimation_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
        private void button6_Click(object sender, EventArgs e)
        {
            #region
            if (activeForm.GetType() == typeof(UIUsuariosView))
            {
                DataGridView dataGridView = ((UIUsuariosView)activeForm).dataUserList;
                uiUsuariosView.DeleteSelectedRow(dataGridView);
            }
            else if (activeForm.GetType() == typeof(UIPersonajeView))
            {
                DataGridView dataGridView = ((UIPersonajeView)activeForm).dataPjt;
            }
            else if (activeForm.GetType() == typeof(UIMisionesTomadasView))
            {

            }
            else if (activeForm.GetType() == typeof(UIMisionesView))
            {

            }
            else if (activeForm.GetType() == typeof(UINpcView))
            {

            }
            #endregion
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}

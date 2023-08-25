using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CRUD_SGBD.Conex;

using System.IO;

namespace CRUD_SGBD
{

    public partial class UIPersonajeView : Form
    {
        public UIPersonajeView()
        {
            InitializeComponent();
        }

        private void UIPersonajeView_Load(object sender, EventArgs e)
        {
            var dataService = new ConexionMySQL(Conex.server, Conex.port, Conex.database, Conex.username, Conex.password);

            var bindingSource = new BindingSource();
            var dataTable = dataService.GetTablaClass("Personaje");
            bindingSource.DataSource = dataTable;
            dataPjt.DataSource = bindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
        }

        private void glControl1_Load(object sender, EventArgs e)
        {

        }

        } 
    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_SGBD
{
    public partial class UIMisionesTomadasView : Form
    {
        public UIMisionesTomadasView()
        {
            InitializeComponent();
        }

        private void UIMisionesTomadasView_Load(object sender, EventArgs e)
        {
            {
                var dataService = new ConexionMySQL(Conex.server, Conex.port, Conex.database, Conex.username, Conex.password);

                var bindingSource = new BindingSource();
                var dataTable = dataService.GetTabla("Tomar_Mision");
                bindingSource.DataSource = dataTable;
                dataMisionesTomadas.DataSource = bindingSource;
            }
        }
    }
}

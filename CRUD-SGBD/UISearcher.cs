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
    public partial class UISearcher : Form
    {
        public UISearcher()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void UISearcher_Load(object sender, EventArgs e)
        {
            SqlQueriesInf sqlQueriesInf = new SqlQueriesInf();
            sqlQueriesInf.SearcherSQL(comboBox1);
        }
    }
}

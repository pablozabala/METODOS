using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneradordeMetodos.CLASES;

namespace GeneradordeMetodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string sql = "select * from " + txtTabla.Text;
            DataTable tb = cDb.GetDatatable(sql);
            DataTable tbColumna = new DataTable();
            tbColumna.Columns.Add("Nombre");
            foreach (DataColumn col in tb.Columns )
            {
                DataRow r = tbColumna.NewRow();
                r[0] = col.ColumnName.ToString();
                tbColumna.Rows.Add(r);
            }
            Grilla.DataSource = tbColumna;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

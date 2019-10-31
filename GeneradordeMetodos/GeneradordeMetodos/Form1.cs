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
        private DataTable tbColumna2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbColumna2 = new DataTable();
            tbColumna2.Columns.Add("Columna");
            tbColumna2.Columns.Add("Tipo");
            cmbTipo.Items.Add("Int32");
            cmbTipo.Items.Add("string");
            cmbTipo.Items.Add("DateTime");
            cmbTipo.Items.Add("Double");
            cmbTipo.SelectedIndex = 0; 
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Grilla.CurrentRow ==null)
            {
                return;
            }
            string col = Grilla.CurrentRow.Cells[0].Value.ToString();
            string tipo = "";
            tipo = cmbTipo.Text;
            if (chkNulo.Checked==true)
            {
                tipo = tipo + "?";
            }
            
            
            DataRow fila = tbColumna2.NewRow();
            fila[0] = col;
            fila[1] = tipo;
            tbColumna2.Rows.Add(fila);
            Grilla2.DataSource = tbColumna2; 
        }

        private void txtMeodos_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnGenerarClase_Click(object sender, EventArgs e)
        {
            string tabla = txtTabla.Text;
            string Metodo = "";
            
            Metodo = "Public void Insertar" + tabla;
            Metodo = Metodo + "(";
            string parametro = "";
            for (int i=0;i< tbColumna2.Rows.Count;i++)
            {
                string col = tbColumna2.Rows[i][0].ToString();
                string tipo = tbColumna2.Rows[i][1].ToString();
                if (parametro =="")
                    parametro = tipo + " " + col;
                else
                    parametro =  "," + tipo + " " + col;
                Metodo = Metodo + parametro;
            }
            Metodo = Metodo + ")";
            Metodo = Metodo + "\n";
            Metodo = Metodo + "{";
            Metodo = Metodo + "\n";
            Metodo = Metodo + " Insert into " + tabla;

        }
    
    }
}

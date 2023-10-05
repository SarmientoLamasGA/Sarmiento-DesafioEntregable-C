using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioEntregable_C
{
    public partial class WdwVenta : Form
    {
        public WdwVenta()
        {
            InitializeComponent();
            List<Venta> lista = Context.VisualizarVentas();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            frmProducto_agregar agregar = new frmProducto_agregar();
            agregar.FormClosed += btnAgregarVenta_Click_FormClosed;
            agregar.ShowDialog();
        }

        private void btnAgregarVenta_Click_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<Venta> lista = Context.VisualizarVentas();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == 0) return;
            int Id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
            List<Venta> producto = Context.VerUnaVenta(Id);
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                frmProducto_borrar borrar = new frmProducto_borrar();
                borrar.FormClosed += btnAgregarVenta_Click_FormClosed;
                borrar.ShowDialog();
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                frmProducto_borrar eliminar = new frmProducto_borrar();
                eliminar.FormClosed += btnAgregarVenta_Click_FormClosed;
                eliminar.ShowDialog();
            }
        }
    }
}

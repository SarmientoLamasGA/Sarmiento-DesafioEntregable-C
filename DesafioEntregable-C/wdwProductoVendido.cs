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
    public partial class WdwProductoVendido : Form
    {
        public WdwProductoVendido()
        {
            InitializeComponent();
            List<ProductoVendido> lista = Context.VisualizarProductosVendidos();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        private void btnAgregarProductoVendido_Click(object sender, EventArgs e)
        {
            frmProductoVendido_agregar agregar = new frmProductoVendido_agregar();
            agregar.FormClosed += wdwProductosVendidos_agregar_FormClosed;
            agregar.ShowDialog();
        }

        private void wdwProductosVendidos_agregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<ProductoVendido> lista = Context.VisualizarProductosVendidos();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == 0) return;
            int Id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
            List<ProductoVendido> producto = Context.VerUnProductoVendido(Id);
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                frmProducto_borrar borrar = new frmProducto_borrar();
                borrar.FormClosed += wdwProductosVendidos_agregar_FormClosed;
                borrar.ShowDialog();
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                frmProducto_borrar eliminar = new frmProducto_borrar();
                eliminar.FormClosed += wdwProductosVendidos_agregar_FormClosed;
                eliminar.ShowDialog();
            }
        }
    }
}

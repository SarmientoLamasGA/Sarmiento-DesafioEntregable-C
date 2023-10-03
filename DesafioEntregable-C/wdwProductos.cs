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
    public partial class WdwProductos : Form
    {
        public WdwProductos()
        {
            InitializeComponent();
            List<Producto> lista = Context.VisualizarProductos();
            dataGridView1.AutoGenerateColumns = false;
            //ACA DEBERIA RENDERIZAR LA LISTA PERO SE PASAN LOS CAMPOS VACIOS
            dataGridView1.DataSource = lista;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmProducto_agregar agregar = new frmProducto_agregar();
            agregar.FormClosed += wdwProductos_agregar_FormClosed;
            agregar.ShowDialog();
        }

        private void wdwProductos_agregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<Producto> lista = Context.VisualizarProductos();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == 0) return;
            int Id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
            List<Producto> producto = Context.VerUnProducto(Id);
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                frmProducto_borrar borrar = new frmProducto_borrar();
                borrar.FormClosed += wdwProductos_agregar_FormClosed;
                borrar.ShowDialog();
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                frmProducto_borrar eliminar = new frmProducto_borrar();
                eliminar.FormClosed += wdwProductos_agregar_FormClosed;
                eliminar.ShowDialog();
            }
        }
    }
}

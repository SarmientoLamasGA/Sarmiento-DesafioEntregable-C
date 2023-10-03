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
    public partial class WdwUsuarios : Form
    {
        public WdwUsuarios()
        {
            InitializeComponent();
            List<Usuario> lista = Context.VisualizarUsuarios();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }
        private void wdwUsuario_agregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<Usuario> lista = Context.VisualizarUsuarios();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        public static List<Usuario> VerUnUsuarios(int id)
        {
            return UsuarioData.ObtenerUsuario(id);
        }

        public static void AgregarUsuario(Usuario usuario)
        {
            UsuarioData.CrearUsuario(usuario);
        }

        public static void QuitarUsuario(Usuario usuario)
        {
            UsuarioData.EliminarUsuario(usuario);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == 0) return;
            int Id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
            List<Usuario> usuario = Context.VerUnUsuario(Id);
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                frmProducto_borrar borrar = new frmProducto_borrar();
                borrar.FormClosed += wdwUsuario_agregar_FormClosed;
                borrar.ShowDialog();
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                frmProducto_borrar eliminar = new frmProducto_borrar();
                eliminar.FormClosed += wdwUsuario_agregar_FormClosed;
                eliminar.ShowDialog();
            }
        }
    }
}

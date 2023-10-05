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
    public partial class frmProductoVendido_borrar : Form
    {
        private ProductoVendido _producto;
        public frmProductoVendido_borrar()
        {
            InitializeComponent();
            this.numIdProducto.Value = Convert.ToUInt32(_producto._IdProducto);
            this.numStock.Value = Convert.ToUInt32(_producto._Stock);
            this.numIdUsuario.Value = Convert.ToUInt32(_producto._IdVenta);
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Context.QuitarProducto(_producto);
            MessageBox.Show("Producto Eliminado");
        }
    }
}
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
    public partial class frmProductoVendido_editar : Form
    {
        private ProductoVendido _producto;

        public frmProductoVendido_editar()
        {
            InitializeComponent();
            _producto._IdProducto = Convert.ToInt32(numIdProducto.Value);
            _producto._Stock = Convert.ToInt32(numStock.Value);
            _producto._IdUsuario = Convert.ToInt32(numIdUsuario.Value);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            ProductoVendido producto = new ProductoVendido();
            producto._IdProducto = Convert.ToInt32(numIdProducto.Value);
            producto._Stock = Convert.ToInt32(numStock.Value);
            producto._IdUsuario = Convert.ToInt32(numIdUsuario.Value);
            Context.AgregarProducto(producto);
            MessageBox.Show("Producto Editado");
        }
    }
}

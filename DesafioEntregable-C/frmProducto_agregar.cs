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
    public partial class frmProducto_agregar : Form
    {
        public frmProducto_agregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto._Descripciones = txtDescripciones.Text;
            producto._Costo = numCosto.Value;
            producto._PrecioVenta = numPrecioVenta.Value;
            producto._Stock = (int)numStock.Value;
            producto._IdUsuario = int.Parse(txtIdUsuario.Text);
            Context.AgregarProducto(producto);
            MessageBox.Show("Producto guardado");
        }
    }
}

namespace DesafioEntregable_C
{
    public partial class wdwBase : Form
    {
        public wdwBase()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            WdwProductos wdwProductos = new WdwProductos();
            wdwProductos.FormClosed += _FormClosed;
            wdwProductos.ShowDialog();
        }

        private void wdwProductos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            WdwUsuarios wdwUsuarios = new WdwUsuarios();
            wdwUsuarios.FormClosed += _FormClosed;
            wdwUsuarios.ShowDialog();
        }

        private void _FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            WdwVenta wdwVenta = new WdwVenta();
            wdwVenta.FormClosed += _FormClosed;
            wdwVenta.ShowDialog();
        }

        private void btnProdcutosVendidos_Click(object sender, EventArgs e)
        {
            WdwProductoVendido wwProductoVendido = new WdwProductoVendido();
            wwProductoVendido.FormClosed += _FormClosed;
            wwProductoVendido.ShowDialog();
        }
    }
}
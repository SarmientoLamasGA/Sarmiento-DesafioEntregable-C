using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEntregable_C
{
    public static class Context
    {

        //PRODUCTOS
        public static List<Producto> VisualizarProductos()
        {
            return ProductoData.ListarProductos();
        }

        public static List<Producto> VerUnProducto(int id)
        {
            return ProductoData.ObtenerProducto(id);
        }
        
        public static void AgregarProducto(Producto producto)
        {
            ProductoData.CrearProducto(producto);
        }

        public static void QuitarProducto(Producto producto)
        {
            ProductoData.EliminarProducto(producto);
        }


        //USUARIO
        public static List<Usuario> VisualizarUsuarios()
        {
            return UsuarioData.ListarUsuarios();
        }
        public static List<Usuario> VerUnUsuario(int id)
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

        //PRODUCTOS VENDIDOS
        public static List<ProductoVendido> VisualizarProductosVendidos()
        {
            return ProductoVendidoData.ListarProductosVendidos();
        }

        public static List<ProductoVendido> VerUnProductoVendido(int id)
        {
            return ProductoVendidoData.ObtenerProductoVendido(id);
        }

        public static void AgregarProducto(ProductoVendido productoVendido)
        {
            ProductoVendidoData.CrearProductoVendido(productoVendido);
        }

        public static void QuitarProducto(ProductoVendido productoVendido)
        {
            ProductoVendidoData.EliminarProductoVendido(productoVendido);
        }

        //VENTAS
        public static List<Venta> VisualizarVentas()
        {
            return VentaData.ListarVentas();
        }

        public static List<Venta> VerUnaVenta(int id)
        {
            return VentaData.ObtenerVenta(id);
        }

        public static void AgregarVenta(Venta venta)
        {
            VentaData.CrearVenta(venta);
        }

        public static void QuitarVenta(Venta venta)
        {
            VentaData.EliminarVenta(venta);
        }

    }
}

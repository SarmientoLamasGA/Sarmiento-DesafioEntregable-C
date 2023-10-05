using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEntregable_C
{
    public class ProductoVendidoData
    {
        public static List<ProductoVendido> ObtenerProductoVendido(int IdproductoVendido)
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "SELECT Id,IdProducto,Stock,IdVenta FROM pruebasClase.dbo.ProductoVendido WHERE Id=@Id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var productoVendido = new ProductoVendido();
                                    productoVendido._Id = Convert.ToInt32(dr["Id"]);
                                    productoVendido._IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                    productoVendido._Stock = Convert.ToInt32(dr["Stock"]);
                                    productoVendido._IdVenta = Convert.ToInt32(dr["IdVenta"]);
                                    lista.Add(productoVendido);
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lista;
        }

        public static List<ProductoVendido> ListarProductosVendidos()
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "SELECT Id,IdProducto,Stock,IdVenta FROM pruebasClase.dbo.ProductoVendido";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var productoVendido = new ProductoVendido();
                                    productoVendido._Id = Convert.ToInt32(dr["Id"]);
                                    productoVendido._IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                    productoVendido._Stock = Convert.ToInt32(dr["Stock"]);
                                    productoVendido._IdVenta = Convert.ToInt32(dr["IdVenta"]);
                                    lista.Add(productoVendido);
                                }
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lista;
        }

        public static void CrearProductoVendido(ProductoVendido producto)
        {
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "INSERT INTO ProductoVendido (IdProducto,Stock,IdVenta)" + "VALUES(@IdProducto,@Stock,@IdVenta)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.VarChar) { Value = producto._IdProducto });
                        command.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto._Stock });
                        command.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.VarChar) { Value = producto._IdVenta });
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void ModificarProductoVendido(ProductoVendido producto)
        {
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "UPDATE Producto" +
                "SET Descripciones = @Descripciones" +
                ",Stock = @Stock" +
                ",IdVenta = @IdVenta" +
                "WHERE Id = @Id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto._Id });
                        command.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.VarChar) { Value = producto._IdProducto });
                        command.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto._Stock });
                        command.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.VarChar) { Value = producto._IdVenta });
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void EliminarProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "DELETE FROM Producto WHERE Id = @Id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = productoVendido._Id });
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


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
            string query = "SELECT Id,IdProducto,Stock,IdUsuario FROM pruebasClase.dbo.ProductoVendido WHERE Id=@Id";

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
                                    productoVendido._IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
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
            string query = "SELECT Id,IdProducto,Stock,IdUsuario FROM pruebasClase.dbo.ProductoVendido";

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
                                    productoVendido._IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
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
            string query = "INSERT INTO ProductoVendido (IdProducto,Stock,IdUsuario)" + "VALUES(@IdProducto,@Stock,@IdUsuario)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.VarChar) { Value = producto._IdProducto });
                        command.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto._Stock });
                        command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = producto._IdUsuario });
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
                ",IdUsuario = @IdUsuario" +
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
                        command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = producto._IdUsuario });
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


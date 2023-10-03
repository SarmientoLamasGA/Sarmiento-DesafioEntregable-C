using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEntregable_C
{
    public class ProductoData
    {
        public static List<Producto> ObtenerProducto(int Idproducto)
        {
            List<Producto> lista = new List<Producto>();
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario FROM pruebasClase.dbo.Producto WHERE Id=@" + Idproducto;

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
                                    var producto = new Producto();
                                    producto._Id = Convert.ToInt32(dr["Id"]);
                                    producto._Descripciones = dr["Descripciones"].ToString();
                                    producto._Costo = Convert.ToInt32(dr["Costo"]);
                                    producto._PrecioVenta = Convert.ToInt32(dr["PrecioVenta"]);
                                    producto._Stock = Convert.ToInt32(dr["Stock"]);
                                    producto._IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                    lista.Add(producto);
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

        public static List<Producto> ListarProductos()
        {
            List<Producto> lista = new List<Producto>();
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario FROM pruebasClase.dbo.Producto";

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
                                    var producto = new Producto();
                                    producto._Id = Convert.ToInt32(dr["Id"]);
                                    producto._Descripciones = dr["Descripciones"].ToString();
                                    producto._Costo = Convert.ToInt32(dr["Costo"]);
                                    producto._PrecioVenta = Convert.ToInt32(dr["PrecioVenta"]);
                                    producto._Stock = Convert.ToInt32(dr["Stock"]);
                                    producto._IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                    lista.Add(producto);
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

        public static void CrearProducto(Producto producto)
        {
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "INSERT INTO Producto (Descripciones,Costo,PrecioVenta,Stock,IdUsuario)" + "VALUES(@Descripciones,@Costo,@PrecioVenta,@Stock,@IdUsuario)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto._Descripciones });
                        command.Parameters.Add(new SqlParameter("Costo", SqlDbType.Money) { Value = producto._Costo });
                        command.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Money) { Value = producto._PrecioVenta});
                        command.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto._Stock });
                        command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = producto._IdUsuario});
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void ModificarProducto(Producto producto)
        {
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "UPDATE Producto" +
                "SET Descripciones = @Descripciones" +
                ",Costo = @Costo" +
                ",PrecioVenta = @PrecioVenta" +
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
                        command.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto._Descripciones });
                        command.Parameters.Add(new SqlParameter("Costo", SqlDbType.Money) { Value = producto._Costo });
                        command.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Money) { Value = producto._PrecioVenta });
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

        public static void EliminarProducto(Producto producto)
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
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto._Id });
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


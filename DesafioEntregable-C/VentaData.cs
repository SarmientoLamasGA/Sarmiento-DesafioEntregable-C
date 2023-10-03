using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEntregable_C
{
    public class VentaData
    {
        public static List<Venta> ObtenerVenta(int IdVenta)
        {
            List<Venta> lista = new List<Venta>();
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "SELECT Id,Comentarios,IdUsuario FROM pruebasClase.dbo.Venta WHERE Id=@Id";

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
                                    var venta = new Venta();
                                    venta._Id = Convert.ToInt32(dr["Id"]);
                                    venta._Comentarios = dr["Comentarios"].ToString();
                                    venta._IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                    lista.Add(venta);
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

        public static List<Venta> ListarVentas()
        {
            List<Venta> lista = new List<Venta>();
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "SELECT Id,Comentarios,IdUsuario FROM pruebasClase.dbo.Venta";

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
                                    var venta = new Venta();
                                    venta._Id = Convert.ToInt32(dr["Id"]);
                                    venta._Comentarios = dr["Comentarios"].ToString();
                                    venta._IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                    lista.Add(venta);
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

        public static void CrearVenta(Venta venta)
        {
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "INSERT INTO Venta (Comentarios,IdUsuario)" + "VALUES(@Comentarios,@IdUsuario)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta._Comentarios });
                        command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = venta._IdUsuario });
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void ModificarVenta(Venta venta)
        {
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "UPDATE Venta" +
                "SET Comentarios = @Comentarios" +
                ",IdUsuario = @IdUsuario" +
                "WHERE Id = @Id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta._Id });
                        command.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta._Comentarios });
                        command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = venta._IdUsuario });
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void EliminarVenta(Venta venta)
        {
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "DELETE FROM Venta WHERE Id = @Id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta._Id });
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


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEntregable_C
{
    public class UsuarioData
    {
        public static List<Usuario> ObtenerUsuario(int IdUsuario)
        {
            List<Usuario> lista = new List<Usuario>();
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM pruebasClase.dbo.Usuario WHERE Id=@" + IdUsuario;

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
                                    var usuario = new Usuario();
                                    usuario._Id = Convert.ToInt32(dr["Id"]);
                                    usuario._Nombre = dr["Nombre"].ToString();
                                    usuario._Apellido = dr["Apellido"].ToString();
                                    usuario._NombreUsuario = dr["NombreUsuario"].ToString();
                                    usuario._Contraseña = dr["Contraseña"].ToString();
                                    usuario._Mail = dr["Mail"].ToString();
                                    lista.Add(usuario);
                                }
                            }
                        }
                    }

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lista;
        }

        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM pruebasClase.dbo.Usuario";

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
                                    var usuario = new Usuario();
                                    usuario._Id = Convert.ToInt32(dr["Id"]);
                                    usuario._Nombre = dr["Nombre"].ToString();
                                    usuario._Apellido = dr["Apellido"].ToString();
                                    usuario._NombreUsuario = dr["NombreUsuario"].ToString();
                                    usuario._Contraseña = dr["Contraseña"].ToString();
                                    usuario._Mail = dr["Mail"].ToString();
                                    lista.Add(usuario);
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

        public static void CrearUsuario(Usuario usuario)
        {
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "INSERT INTO Usuario (Nombre,Apellido,NombreUsuario,Contraseña,Mail)" + "VALUES(@Nombre,@Apellido,@NombreUsuario,@Contraseña,@Mail)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario._Nombre });
                        command.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario._Apellido });
                        command.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario._NombreUsuario });
                        command.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario._Contraseña });
                        command.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario._Mail });
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void ModificarUsuario(Usuario usuario)
        {
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "UPDATE Usuario" +
                "SET Nombre = @Nombre" +
                ",Apellido = @Apellido" +
                ",NombreUsuario = @NombreUsuario" +
                ",Contraseña = @Contraseña" +
                ",Mail = @Mail" +
                "WHERE Id = @Id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = usuario._Id });
                        command.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario._Nombre });
                        command.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario._Apellido });
                        command.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario._NombreUsuario });
                        command.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario._Contraseña });
                        command.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario._Mail });
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void EliminarUsuario(Usuario usuario)
        {
            string connectionString = @"Server=DESKTOP-D8L8JL0\MSSQLSERVER01;Database=pruebasClase;Trusted_Connection=True";
            string query = "DELETE FROM Usuario WHERE Id = @Id"; 

            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = usuario._Id });
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


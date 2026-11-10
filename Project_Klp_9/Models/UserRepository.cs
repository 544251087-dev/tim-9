using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Project_Klp_9.Models
{
    public class UserRepository : Iautentifikasi
    {
        private readonly string connectionString = "server=localhost;database=siakada;uid=root;pwd=";

        public Model authenticate(string users, string password, string role)
        {
            Model user = null;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE username = @username AND password_hash = @password AND role = @role";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", users);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new Model()
                            {
                                Id = reader.GetInt32("id"),
                                users = reader.GetString("username"),
                                password = reader.GetString("password_hash"),
                                role = reader.GetString("role"),
                                poinjiwa = reader.GetInt32("poinjiwa"),
                                poinpelanggaran = reader.GetInt32("poinpelanggaran")
                            };
                        }
                    }
                }
            }
            return user;
        }

        public Model Authenticate(string users, string password, string role)
        {
            return authenticate(users, password, role);
        }
    }
}
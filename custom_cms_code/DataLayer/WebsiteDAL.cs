using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DataLayer
{
    public class WebsiteDAL : IWebsite, IWebsiteContainer
    {
        public WebsiteDTO FindById(int id)
        {
            WebsiteDTO website = new WebsiteDTO(1, "nonexistend", "nonexistend");
            
            using (SqlConnection con = new SqlConnection(GlobalVars.connectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Websites WHERE id = @id", con);
                sqlCommand.Parameters.AddWithValue("@id", id);
                using (sqlCommand)
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        website = new WebsiteDTO((int)reader["Id"], (string)reader["Name"], (string)reader["Domain"]);
                    }
                }
            }
            return website;
        }

        public List<WebsiteDTO> GetAll()
        {
            List<WebsiteDTO> websites = new List<WebsiteDTO>();

            using (SqlConnection con = new SqlConnection(GlobalVars.connectionString))
            {
                con.Open();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Websites", con))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        websites.Add(new WebsiteDTO((int)reader["Id"], (string)reader["Name"], (string)reader["Domain"]));
                    }
                }
                con.Close();
            }
            return websites;
        }

        public void CreateWebsite(WebsiteDTO website)
        {
            using (SqlConnection con = new SqlConnection(GlobalVars.connectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Websites (Name, Domain) VALUES (@name, @domain)", con);
                sqlCommand.Parameters.AddWithValue("@name", website.Name);
                sqlCommand.Parameters.AddWithValue("@domain", website.Domain);
                int rowsaffected = sqlCommand.ExecuteNonQuery();
                con.Close();
            }
        }

        public void UpdateWebsite(WebsiteDTO website)
        {
            using (SqlConnection con = new SqlConnection(GlobalVars.connectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE Websites SET Name = @name, Domain = @domain WHERE Id = @id", con);
                sqlCommand.Parameters.AddWithValue("@id", website.Id);
                sqlCommand.Parameters.AddWithValue("@name", website.Name);
                sqlCommand.Parameters.AddWithValue("@domain", website.Domain);
                int rowsaffected = sqlCommand.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteWebsite(int id)
        {
            using (SqlConnection con = new SqlConnection(GlobalVars.connectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Websites WHERE Id = @id", con);
                sqlCommand.Parameters.AddWithValue("@id", id.ToString());
                int rowsaffected = sqlCommand.ExecuteNonQuery();
                con.Close();
            }
        }

        public void UpdatePage(WebsiteDTO website)
        {
            throw new NotImplementedException();
        }
    }
}

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
            }
            return websites;
        }

        public void CreateWebsite(WebsiteDTO website)
        {
            using (SqlConnection con = new SqlConnection(GlobalVars.connectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Pages (Name, Domain) VALUES (@name, @domain)", con);
                sqlCommand.Parameters.AddWithValue("@name", website.Name);
                sqlCommand.Parameters.AddWithValue("@domain", website.Domain);
                int rowsaffected = sqlCommand.ExecuteNonQuery();
            }
        }
    }
}

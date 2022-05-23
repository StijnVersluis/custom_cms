using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataLayer
{
    public class PageDAL : IPage, IPageContainer
    {
        public PageDTO FindById(int id)
        {
            PageDTO page = new PageDTO(1, 1, "nonexistent");

            using (SqlConnection con = new SqlConnection(GlobalVars.connectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Pages where Id = @id", con);
                sqlCommand.Parameters.AddWithValue("@id", id);
                using (sqlCommand)
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        MessageBox.Show((string)reader["Location"]);
                        page = new PageDTO((int)reader["Id"], (int)reader["Website_id"], (string)reader["Location"]);
                    }
                }
            }

            return page;
        }

        public List<PageDTO> GetAll(int websiteId)
        {
            List<PageDTO> pages = new List<PageDTO>();

            using (SqlConnection con = new SqlConnection(GlobalVars.connectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Pages WHERE Website_id = @website_id", con);
                sqlCommand.Parameters.AddWithValue("@website_id", websiteId);
                using (sqlCommand)
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        pages.Add(new PageDTO((int)reader["Id"], (int)reader["Website_id"], (string)reader["Location"]));
                    }
                }
            }

            return pages;
        }

        public void CreatePage(PageDTO page)
        {
            using (SqlConnection con = new SqlConnection(GlobalVars.connectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Pages (Website_id, Location) VALUES (@website_id, @location)", con);
                sqlCommand.Parameters.AddWithValue("@website_id", page.WebsiteId);
                sqlCommand.Parameters.AddWithValue("@location", page.Location);
                int rowsaffected = sqlCommand.ExecuteNonQuery();
            }
        }

        public void EditPage(PageDTO page)
        {
            using (SqlConnection con = new SqlConnection(GlobalVars.connectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE Pages SET Website_id = @website_id, Location = @location WHERE Id = @id", con);
                sqlCommand.Parameters.AddWithValue("@id", page.Id);
                sqlCommand.Parameters.AddWithValue("@website_id", page.WebsiteId);
                sqlCommand.Parameters.AddWithValue("@location", page.Location);
                int rowsaffected = sqlCommand.ExecuteNonQuery();
            }
        }

        public void DeletePage(int id)
        {
            using (SqlConnection con = new SqlConnection(GlobalVars.connectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Pages WHERE Id = @id", con);
                sqlCommand.Parameters.AddWithValue("@id", id);
                int rowsaffected = sqlCommand.ExecuteNonQuery();
            }
        }
    }
}

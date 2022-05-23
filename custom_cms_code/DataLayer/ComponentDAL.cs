using Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLayer
{
    public class ComponentDAL : IComponentContainer, IComponent
    {
        List<ComponentDTO> components = new List<ComponentDTO>();
        public List<ComponentDTO> GetAllFromPage(int pageId)
        {
            List<ComponentDTO> components = new List<ComponentDTO>();

            using (SqlConnection con = new SqlConnection(GlobalVars.connectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT Components.Id as compId, Page_components.Id as pCompId, * FROM Components INNER JOIN Page_components on Components.Id = Component_id where Page_id = @id", con);
                sqlCommand.Parameters.AddWithValue("@id", pageId);
                using (sqlCommand)
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        ///compId	pCompId	Id	Name	Html	                Is_shown	Updated_at	    Id	Component_id	Page_id	Order	Attribute_json	        Updated_at
                        //1          1       1   Div    <div>{ { text} }</ div >     1   0x00000000000007DD  1   1              1       1       { text: "Hello World"}  0x00000000000007E0
                        string atrr = (string)reader["Attribute_json"];

                        Attributes atr = JsonSerializer.Deserialize<Attributes>(atrr);

                        string html = (string)reader["Html"];

                        foreach(var prop in atr.GetType().GetProperties())
                        {
                            //If the component doesn't contain the "{{text}}" or another property then skip the replacement
                            if (atr.GetType().GetProperty(prop.Name).GetValue(atr) != null)
                            {
                                //Replace the "{{text}}" with the value that is inputted
                                html = html.Replace("{{" + prop.Name + "}}", atr.GetType().GetProperty(prop.Name).GetValue(atr).ToString());
                            }
                        }
                        var comp = new ComponentDTO((int)reader["Id"], (int)reader["pCompId"], (string)reader["Name"], html, false);
                        components.Add(comp);
                    }
                }
            }

            return components;
        }

        public ComponentDTO FindById(int id)
        {
            ComponentDTO dTO = new ComponentDTO(0, "Nonexistend", "<div>Nonexisted</div>", false);
            using (SqlConnection con = new SqlConnection(GlobalVars.connectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Components where id = @id", con);
                sqlCommand.Parameters.AddWithValue("@id", id);
                using (sqlCommand)
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        ///compId	pCompId	Id	Name	Html	                Is_shown	Updated_at	    Id	Component_id	Page_id	Order	Attribute_json	        Updated_at
                        //1          1       1   Div    <div>{ { text} }</ div >     1   0x00000000000007DD  1   1              1       1       { text: "Hello World"}  0x00000000000007E0
                        components.Add(new ComponentDTO((int)reader["Id"], (string)reader["Name"], (string)reader["Html"], (bool)reader["Is_shown"]));
                    }
                }
            }
            return dTO;
        }

        public List<ComponentDTO> GetAll()
        {
            List<ComponentDTO> pages = new List<ComponentDTO>();

            using (SqlConnection con = new SqlConnection(GlobalVars.connectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Components", con);
                using (sqlCommand)
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        pages.Add(new ComponentDTO((int)reader["Id"], (string)reader["Name"], (string)reader["Html"], (bool)reader["Is_shown"]));
                    }
                }
            }

            return pages;
        }
    }
}

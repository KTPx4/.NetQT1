using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Xml.Linq;

namespace ASP.Models
{
    public class ModelProduct
    {
        public string? ID { get; set; }
        public string? Name { get; set; }
        public string? Size { get; set; }
        public double? Price { get; set; }


        public List<ModelProduct> GetProducts(string connectionString)
        {
            List<ModelProduct> ListItems = new List<ModelProduct>();

            SqlConnection con = new SqlConnection(connectionString);

            string sqlQuery = "select ItemID, ItemName, Size, Price from Item";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con); 
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    ModelProduct ItemParameter = new ModelProduct();
                   
                    ItemParameter.ID = dr["ItemID"].ToString();
                    ItemParameter.Name = dr["ItemName"].ToString();
                    ItemParameter.Size = dr["Size"].ToString();
                    ItemParameter.Price = double.Parse(dr["Price"].ToString());
                    ListItems.Add(ItemParameter);
                }
            }
            return ListItems;
        }

        public bool isExistsID(string id, string connectionString)
        {
          
           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Item WHERE ItemID = @ItemID", conn))
                {
                    cmd.Parameters.AddWithValue("@ItemID", id);

                    int existingItemCount = (int)cmd.ExecuteScalar();               

                    if (existingItemCount > 0)
                    {
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        conn.Close();
                        return false;
                    }
                }
              

            }
        }
        
        public void Add(ModelProduct item, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Item(ItemID, ItemName, Size, Price) VALUES(@id, @name, @size, @price)", conn))
                {
                    cmd.Parameters.AddWithValue("@id", item.ID);
                    cmd.Parameters.AddWithValue("@name", item.Name);

                    cmd.Parameters.AddWithValue("@size", item.Size);
                    cmd.Parameters.AddWithValue("@price", item.Price);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();

            }
        }
    
        public void Remove(ModelProduct item, string connectionString) 
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM Item WHERE ItemID = @ItemID", conn))
                {
                    cmd.Parameters.AddWithValue("@ItemID", item.ID);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
    
    }
}

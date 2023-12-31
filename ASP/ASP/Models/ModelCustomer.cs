﻿using System.Data.SqlClient;

namespace ASP.Models
{
 
    public class ModelCustomer
    {
        public string? ID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }



        public List<ModelCustomer> GetCustomer(string connectionString)
        {
            List<ModelCustomer> ListCust = new List<ModelCustomer>();

            SqlConnection con = new SqlConnection(connectionString);

            string sqlQuery = "select * from Customer";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    ModelCustomer CustParameter = new ModelCustomer();

                    CustParameter.ID = dr["CustID"].ToString();
                    CustParameter.Name = dr["CustName"].ToString();
                    CustParameter.Address = dr["Address"].ToString();
                       
                    ListCust.Add(CustParameter);
                }
            }
            return ListCust;
        }
        public bool isExistsID(string id, string connectionString)
        {


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM customer WHERE CustID = @ItemID", conn))
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

        public void Add(ModelCustomer item, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Customer VALUES(@id, @name, @addr)", conn))
                {
                    cmd.Parameters.AddWithValue("@id", item.ID);
                    cmd.Parameters.AddWithValue("@name", item.Name);

                    cmd.Parameters.AddWithValue("@addr", item.Address);
                  
                    cmd.ExecuteNonQuery();
                }
                conn.Close();

            }
        }

        public void Remove(ModelCustomer item, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM Customer WHERE CustID = @ItemID", conn))
                {
                    cmd.Parameters.AddWithValue("@ItemID", item.ID);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
    }

}

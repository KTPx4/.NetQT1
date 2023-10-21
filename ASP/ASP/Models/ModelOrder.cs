using System.Data.SqlClient;

namespace ASP.Models
{
    public class ModelOrder
    {
        public string OrderID {  get; set; }
        public string OrderDate {  get; set; } 
	    public string CustID { get; set; }

        public List<ModelOrder> GetOrder(string connectionString)
        {
            List<ModelOrder> ListCust = new List<ModelOrder>();

            SqlConnection con = new SqlConnection(connectionString);

            string sqlQuery = "select * from [Order]";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    ModelOrder CustParameter = new ModelOrder();

                    CustParameter.OrderID = dr["OrderID"].ToString();
                    CustParameter.OrderDate = dr["OrderDate"].ToString();
                    CustParameter.CustID = dr["CustID"].ToString();

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

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [Order] WHERE OrderID = @ItemID", conn))
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

        public void Add(ModelOrder item, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO [Order] VALUES(@id, @date, @cust)", conn))
                {
                    cmd.Parameters.AddWithValue("@id", item.CustID);
                    cmd.Parameters.AddWithValue("@date", item.OrderDate);

                    cmd.Parameters.AddWithValue("@cust", item.CustID);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();

            }
        }

    }
}

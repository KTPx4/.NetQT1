using System.Data.SqlClient;

namespace ASP.Models
{
    public class Items
    {
        public string ItemID { get; set; }
        public int Quantity { get; set; }
        public double UnitAmount { get; set; }
    }

    public class ModelOrderDetail
    {
        public string DetailID { get; set; }
        
        public ModelOrder Order { get; set; }

        public Items Items { get; set; }
 

        public bool isExistsID(string id, string connectionString)
        {


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM OrderDetail WHERE ID = @ItemID", conn))
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

        public void Add(ModelOrderDetail item, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO OrderDetail VALUES(@id, @OrderID, @ItemID, @Quan, @Unit)", conn))
                {
                    cmd.Parameters.AddWithValue("@id", item.DetailID);
                    cmd.Parameters.AddWithValue("@OrderID", item.Order.OrderID);
                    cmd.Parameters.AddWithValue("@ItemID", item.Items.ItemID); 
                    cmd.Parameters.AddWithValue("@Quan", item.Items.Quantity);
                    cmd.Parameters.AddWithValue("@Unit", item.Items.UnitAmount);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();

            }
        }
    }
}

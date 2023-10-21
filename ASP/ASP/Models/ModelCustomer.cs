using System.Data.SqlClient;

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
    }

}

using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace ASP.Models
{
    public class LoginViewModel 
    {
        public string? username { get; set; }
        public string? password { get; set; }

        public bool? isConfirm { get; set; }


        public List<LoginViewModel> GetAccount(string connectionString, string user, string pass)
        {
            List<LoginViewModel> ListItems = new List<LoginViewModel>();

            SqlConnection con = new SqlConnection(connectionString);

            string sqlQuery = $"select * from account where username = '{user}' and password= '{pass}'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    LoginViewModel account = new LoginViewModel();

                    account.username = dr["username"].ToString();
                    account.password = dr["password"].ToString();
                    account.isConfirm = bool.Parse(dr["isConfirm"].ToString()); 
                    ListItems.Add(account);
                }
            }
            return ListItems;
        }
    }
}

using ASP.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.Pages
{

        [Authorize]
        public class OrderModel : PageModel
        {
            readonly IConfiguration _configuration;

            public List<ModelOrder> ListO = new List<ModelOrder>();

            public string connectionString;
            public OrderModel(IConfiguration configuration)
            {
                _configuration = configuration;
            }
            public void OnGet()
            {
                ModelOrder cust = new ModelOrder();
                connectionString = _configuration.GetConnectionString("ConnectionString");
                ListO = cust.GetOrder(connectionString);
            }
        }
}


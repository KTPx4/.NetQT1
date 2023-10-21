using ASP.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.Pages
{
    [Authorize]
    public class CustomerModel : PageModel
    {
        readonly IConfiguration _configuration;

        public List<ModelCustomer> ListCust = new List<ModelCustomer>();

        public string connectionString;
        public CustomerModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            ModelCustomer cust = new ModelCustomer();
            connectionString = _configuration.GetConnectionString("ConnectionString");
            ListCust = cust.GetCustomer(connectionString);
        }
    }
}

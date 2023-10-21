using ASP.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;

namespace ASP.Pages
{
    [Authorize]
    public class ProductModel : PageModel
    {
        readonly IConfiguration _configuration;

        public List<ModelProduct> ListProducts = new List<ModelProduct>();

        public string connectionString;
        public ProductModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            ModelProduct measurement = new ModelProduct();
            connectionString = _configuration.GetConnectionString("ConnectionString");
            ListProducts = measurement.GetProducts(connectionString);
        }
 
        public void OnPost()
        {

        }

    }
}

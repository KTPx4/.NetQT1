using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace ASP.Pages
{
    [BindProperties]
    public class LoginModel : PageModel
    {
  
        [Required]
        public string? UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? PassWord { get; set; }

        public void OnGet()
        {
            
        }

        

    }
    public class Account
    {
      
    }
}

using ASP.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Security.Claims;

namespace ASP.Pages
{

    public class LoginModel : PageModel
    {

        readonly IConfiguration _configuration;
        public string connectionString;

        [BindProperty]
        public LoginViewModel Input { get; set; }

        public LoginModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                // Thực hiện kiểm tra đăng nhập và xác thực người dùng
               
                int isAuth = AuthenticateUser(Input.username, Input.password);

                if (isAuth == 0)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, Input.username),
                        // Thêm các claim khác nếu cần
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    // Đăng nhập người dùng
                    await HttpContext.SignInAsync("Cookies", claimsPrincipal);

                    return RedirectToPage("/Index"); // Chuyển hướng đến trang chính
                }
                else if(isAuth == -1)
                {
                    // Xác thực không thành công
                    ModelState.AddModelError("", "Tên người dùng hoặc mật khẩu không hợp lệ.");
                    ViewData["UserData"] = "Username or Password not correct!";
                }
                else if (isAuth == 1)
                {
                    // Xác thực không thành công
                    ModelState.AddModelError("", "Yêu cầu confirm email");
                    ViewData["UserData"] = "Please Confirm your email!";
                }


            }

            return Page();
        }

        public int AuthenticateUser(string username, string password)
        {
            LoginViewModel acc = new LoginViewModel();

            connectionString = _configuration.GetConnectionString("ConnectionString");

            List<LoginViewModel> LAcc = acc.GetAccount(connectionString, username, password);

            if(LAcc.Count < 1)
            {
                return -1;

            }
            else if (LAcc[0].isConfirm == false)
            {
               // sendEmail(username);
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public void sendEmail(string email)
        {

        }

    }
    public class Account
    {
      
    }
}

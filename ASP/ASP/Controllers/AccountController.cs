using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ASP.Models;

namespace ASP.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            // Validate the model
            // Xác thực người dùng
            var user = AuthenticateUser(model.Username, model.Password);

            if (user != null)
            {
                // Tạo ClaimsPrincipal
                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, model.Username),
                        // Thêm các claim khác nếu cần
                    };

                var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(claims, "CookieAuth"));

                // Đăng nhập người dùng
                await HttpContext.SignInAsync("CookieAuth", claimsPrincipal);

                // Chuyển hướng người dùng đến trang chủ
                return RedirectToAction("Index", "Home");
            }

            // Xác thực không thành công
            ModelState.AddModelError("", "Tên người dùng hoặc mật khẩu không hợp lệ.");
            return View(model);
        }
        public string AuthenticateUser(string username, string password)
        {
            return "ok";
        }
    }
}

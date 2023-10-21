using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class RegisterModel : PageModel
{
    private readonly IConfiguration _configuration;
    private readonly SmtpClient _smtpClient;

    public RegisterModel(IConfiguration configuration, SmtpClient smtpClient)
    {
        _configuration = configuration;
        _smtpClient = smtpClient;
    }

    [BindProperty]
    public InputModel Input { get; set; }

    public class InputModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var connectionString = _configuration.GetConnectionString("ConnectionString");
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (var command = new SqlCommand("INSERT INTO account (username, password, isConfirm) VALUES (@username, @password, 0)", connection))
            {
                command.Parameters.AddWithValue("@username", Input.Username);
                command.Parameters.AddWithValue("@password", Input.Password);
                await command.ExecuteNonQueryAsync();
            }
        }

        var message = new MailMessage("px4.vnd@gmail.com", Input.Username)
        {
            Subject = "Confirm your account",
            Body = $"Please confirm your account by <a href='/account/confirm?username={Input.Username}'>clicking here</a>."
        };
        await _smtpClient.SendMailAsync(message);

        return RedirectToPage("/Index");
    }
}



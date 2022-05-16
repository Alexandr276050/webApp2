using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class Home1Model : PageModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
           
        }
        public void OnPost(string? login, string? password)
        {
            
            if (login == null && password == null)
            {
                Message = "Вам нужно ввести логи и пароль";
            }
            else
            {
                Login = login;
                Password = password;
                Message = $"Логин: {login} \nПароль: {password}";
            }

        }

    }
}

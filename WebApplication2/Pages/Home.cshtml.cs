using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class HomeModel : PageModel
    {
        public string Message { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public void OnGet(string? name,int? age )
        {
            if(name !=null && age != null)
            {
                if (age < 21)
                {
                    Message = "Сайт доступен с 21 года";
                }
                else
                {
                    Message = "Добро пожаловать на сайт";
                    Age = age;
                    Name = name;
                }
                
            }
            else
            {
                Message = "Вы не ввели никаких данных";
            }
           
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class PizzaOrderModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
        }
        public void OnPost(int? sum)
        {
            if(sum == null)
            {
                Message = "�� �� ��������� ������� �����";
            }
            else
            {
                var NoOfPizza = sum / 10;
                Message = $"�� ��������{NoOfPizza}";
            }

        }
    }
}

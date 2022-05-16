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
                    Message = "���� �������� � 21 ����";
                }
                else
                {
                    Message = "����� ���������� �� ����";
                    Age = age;
                    Name = name;
                }
                
            }
            else
            {
                Message = "�� �� ����� ������� ������";
            }
           
        }
    }
}

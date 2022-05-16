using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class MoneysModel : PageModel
    {
        public string? Password { get; set; }
        public int? Tenge { get; set; }
        public int? Rubl { get; set; }
        public int? Dollar { get; set; }
        public int? Euro { get; set; }
        public string? Message { get; set; }
        public void OnGet()
        {

        }
        public void OnPost(int? tenge, string? password, int? dollar, int? rubl, int? euro)
        {

            if (tenge== null && password == null)
            {
                Message = "��� ����� ������ ���� � ������";
            }
            else
            {
                Tenge = tenge;
                Password = password;
                rubl = tenge / 7;
                Rubl = rubl;
                dollar = tenge / 433;
                Dollar = dollar;
                euro = tenge / 450;
                Euro = euro;
                Message = $"�����: {tenge} \n     �����: {rubl} \n     �������: {dollar} \n      ����: {euro}";
            }

        }

    }
}


using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityManager.Pages.Exercicio01
{
    public class Exercicio01Model : PageModel
    {
        [BindProperty]
        public string CityName { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public void OnPost()
        {
        }
    }
}

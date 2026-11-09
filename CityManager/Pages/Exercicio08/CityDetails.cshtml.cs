using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CityManager.Pages.Exercicio08;
public class Exercicio08Model : PageModel
{
    public string CityName { get; private set; } = "";
    public void OnGet(string cityName) => CityName = cityName;
}

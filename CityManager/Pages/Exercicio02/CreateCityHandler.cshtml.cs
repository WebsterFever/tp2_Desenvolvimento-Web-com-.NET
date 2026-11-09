using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CityManager.Pages.Exercicio02;
public class Exercicio02Model : PageModel
{
    public string? SubmittedCity { get; private set; }
    public void OnPost(string cityName) => SubmittedCity = cityName;
}

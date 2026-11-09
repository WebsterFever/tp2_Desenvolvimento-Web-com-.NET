using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CityManager.Pages.CityManager;
public class CreateCityHandlerModel : PageModel
{
    public string? SubmittedCity { get; private set; }
    public void OnPost(string cityName) => SubmittedCity = cityName;
}

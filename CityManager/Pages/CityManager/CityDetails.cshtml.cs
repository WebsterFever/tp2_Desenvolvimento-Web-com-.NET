using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CityManager.Pages.CityManager;
public class CityDetailsModel : PageModel
{
    public string CityName { get; private set; } = "";
    public void OnGet(string cityName) => CityName = cityName;
}

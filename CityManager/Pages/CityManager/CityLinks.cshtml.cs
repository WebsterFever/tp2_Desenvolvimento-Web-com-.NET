using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CityManager.Pages.CityManager;
public class CityLinksModel : PageModel
{
    public List<string> Cities { get; } = new() { "Rio", "São Paulo", "Brasília" };
}

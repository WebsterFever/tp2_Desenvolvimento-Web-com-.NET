using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CityManager.Pages.Exercicio09;
public class Exercicio09Model : PageModel
{
    public List<string> Cities { get; } = new() { "Rio", "São Paulo", "Brasília" };
}

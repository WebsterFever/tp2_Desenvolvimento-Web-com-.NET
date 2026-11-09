using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CityManager.Pages.Exercicio10;
public class Exercicio10Model : PageModel
{
    private readonly IWebHostEnvironment _environment;
    public Exercicio10Model(IWebHostEnvironment environment) => _environment = environment;
    [BindProperty]
    public InputModel Input { get; set; } = new();
    public string? FileName { get; private set; }
    public class InputModel
    {
        [Required(ErrorMessage = "Escreva uma anotação.")]
        public string Content { get; set; } = "";
    }
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();
        string folder = Path.Combine(_environment.WebRootPath, "files");
        Directory.CreateDirectory(folder);
        FileName = $"note-{DateTime.UtcNow:yyyyMMddHHmmssfff}-{Guid.NewGuid():N}.txt";
        await System.IO.File.WriteAllTextAsync(Path.Combine(folder, FileName), Input.Content);
        return Page();
    }
}

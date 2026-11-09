using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CityManager.Pages.CityManager;
public class ReadNotesModel : PageModel
{
    private readonly IWebHostEnvironment _environment;
    public ReadNotesModel(IWebHostEnvironment environment) => _environment = environment;
    public List<string> Files { get; private set; } = new();
    public string? Content { get; private set; }
    public string? SelectedFile { get; private set; }
    public async Task<IActionResult> OnGetAsync(string? fileName)
    {
        string folder = Path.Combine(_environment.WebRootPath, "files");
        Directory.CreateDirectory(folder);
        Files = Directory.GetFiles(folder, "note-*.txt")
            .Select(Path.GetFileName).OfType<string>()
            .OrderByDescending(x => x).ToList();
        if (fileName is not null)
        {
            if (!Files.Contains(fileName, StringComparer.Ordinal)) return NotFound();
            Content = await System.IO.File.ReadAllTextAsync(Path.Combine(folder, fileName));
            SelectedFile = fileName;
        }
        return Page();
    }
}

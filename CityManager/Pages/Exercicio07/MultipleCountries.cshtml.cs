using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CityManager.Pages.Exercicio07;
public class Exercicio07Model : PageModel
{
    [BindProperty]
    public List<InputModel> Countries { get; set; } = new();
    public List<InputModel> SubmittedCountries { get; private set; } = new();
    public class InputModel
    {
        [Required(ErrorMessage = "Informe o país.")]
        public string CountryName { get; set; } = "";
        [Required(ErrorMessage = "Informe o código.")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "Use 2 caracteres.")]
        public string CountryCode { get; set; } = "";
    }
    public void OnGet() => Countries = Enumerable.Range(0, 5).Select(_ => new InputModel()).ToList();
    public void OnPost()
    {
        if (Countries.Count != 5)
            ModelState.AddModelError("", "Envie exatamente 5 países.");
        if (!ModelState.IsValid) return;
        SubmittedCountries = Countries.ToList();
    }
}

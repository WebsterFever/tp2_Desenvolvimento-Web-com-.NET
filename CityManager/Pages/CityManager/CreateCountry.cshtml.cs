using System.ComponentModel.DataAnnotations;
using CityManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CityManager.Pages.CityManager;
public class CreateCountryModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; } = new();
    public Country? CreatedCountry { get; private set; }
    public class InputModel
    {
        [Required(ErrorMessage = "Informe o país.")]
        public string CountryName { get; set; } = "";
        [Required(ErrorMessage = "Informe o código.")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "O código deve ter 2 letras.")]
        [RegularExpression("^[A-Za-z]{2}$", ErrorMessage = "Use exatamente 2 letras.")]
        public string CountryCode { get; set; } = "";
    }
    public void OnPost()
    {
        if (!ModelState.IsValid) return;
        var name = Input.CountryName.Trim();
        var code = Input.CountryCode.Trim().ToUpperInvariant();
        if (name.Length == 0 || char.ToUpperInvariant(name[0]) != code[0])
        {
            ModelState.AddModelError("Input.CountryCode", "País e código devem começar com a mesma letra.");
            return;
        }
        CreatedCountry = new Country { CountryName = name, CountryCode = code };
    }
}

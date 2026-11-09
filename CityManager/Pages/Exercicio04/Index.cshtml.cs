using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CityManager.Pages.Exercicio04;
public class Exercicio04Model : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; } = new();
    public string? Message { get; private set; }
    public class InputModel
    {
        [Required(ErrorMessage = "Informe o nome da cidade.")]
        [MinLength(3, ErrorMessage = "Use pelo menos 3 caracteres.")]
        public string CityName { get; set; } = "";
    }
    public void OnPost()
    {
        if (!ModelState.IsValid) return;
        Message = $"Cidade cadastrada: {Input.CityName}";
    }
}

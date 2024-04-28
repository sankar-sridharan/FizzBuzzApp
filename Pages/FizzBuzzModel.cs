using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzzApp.Services; 
namespace FizzBuzzApp.Pages
{
    public class FizzBuzzModel : PageModel
    {
        private readonly FizzBuzzService _fizzBuzzService;

        public FizzBuzzModel(FizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        [BindProperty]
        public int InputValue { get; set; }

        public List<string> FizzBuzzResults { get; private set; }

        public void OnGet()
        {
            // Optional: Initialize any default values
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            FizzBuzzResults = _fizzBuzzService.GenerateFizzBuzzResults(InputValue);
            return Page();
        }
    }
}

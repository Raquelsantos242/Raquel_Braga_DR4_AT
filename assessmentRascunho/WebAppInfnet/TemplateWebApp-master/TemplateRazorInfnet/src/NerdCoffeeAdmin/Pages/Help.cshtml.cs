using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.Design;
using MeuMiniMuseu.Data;
using MeuMiniMuseu.Data.Models;

namespace MeuMiniMuseu.Pages
{
    public class HelpModel : PageModel
    {
        public async Task<IActionResult> OnGet()
        {
            return Page();
        }
    }
}

using MeuMiniMuseu.Data;
using MeuMiniMuseu.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MeuMiniMuseu.Pages.paginasMenu
{
    public class ViewPaintingsModel : PageModel
    {
        private IRepositoryPainting repo;

        public List<Pintura>Pinturas { get; set; } 

        public ViewPaintingsModel(IRepositoryPainting repo)
        {
            this.repo = repo;
        }
        public void OnGet()
        {
            Pinturas = repo.GetAll();
        }
    }
}

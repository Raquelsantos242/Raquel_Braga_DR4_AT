using MeuMiniMuseu.Data;
using MeuMiniMuseu.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Headers;

namespace MeuMiniMuseu.Pages.paginasMenu
{
    public class EditModel : PageModel
    {
		private IWebHostEnvironment env;
		private IRepositoryPainting repo;

        public EditModel(IRepositoryPainting repositoryPainting, IWebHostEnvironment env)
        {
            this.repo = repositoryPainting;
            this.env = env;
        }
        [FromRoute]
        public int id { get; set; }

        [BindProperty]
        public Pintura Edit { get; set; }


		public void OnGet()
        {
            Edit = this.repo.GetById(id);

        }
        public async Task<IActionResult> OnPostEdit()
        {
            if (!ModelState.IsValid) { return Page(); }
            if(Edit.Upload is not null)
            {
                Edit.ImageFile = Edit.Upload.FileName;
                var file = Path.Combine(env.ContentRootPath, "wwwroot/images", Edit.Upload.FileName);
                using(var fileStream = new FileStream(file, FileMode.Create))
                {
                    await Edit.Upload.CopyToAsync(fileStream);
                }
            }
            Edit.Created = DateTime.Now;
            Edit.Id = id;
            this.repo.Update(Edit);

            return RedirectToPage("ViewPaintings");

        }
        public IActionResult Delete()
        {
            this.repo.Delete(id);
            return RedirectToPage("ViewPaintings");
        }
    }
}

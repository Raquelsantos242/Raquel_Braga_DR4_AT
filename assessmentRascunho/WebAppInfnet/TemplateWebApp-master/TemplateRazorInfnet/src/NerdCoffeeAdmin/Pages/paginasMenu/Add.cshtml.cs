using MeuMiniMuseu.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MeuMiniMuseu.Pages.paginasMenu
{

    public class AddModel : PageModel
        {
            private ArtContext context;
            private IWebHostEnvironment env;
		private IRepositoryPainting repo;

		[BindProperty]
            public MeuMiniMuseu.Data.Models.Pintura NewPainting { get; set; }
            public void OnGet()
            {
            }
        public AddModel(IRepositoryPainting repo, IWebHostEnvironment env)
        {
            this.repo = repo; ;
            this.env = env;
        }


        public IActionResult OnPost()
            {



            if (!ModelState.IsValid)
            {
                return Page();
            }
                if (NewPainting is not null)
                {
                    NewPainting.ImageFile = NewPainting.Upload.FileName;
                    var file = Path.Combine(env.ContentRootPath
                        , "wwwroot/images"
                        , NewPainting.Upload.FileName);

                    using (var filestream = new FileStream(file, FileMode.Create))
                    {
                        NewPainting.Upload.CopyTo(filestream);
                    }
                }

            NewPainting.Created = DateTime.Now;
            repo.Add(NewPainting);
            return RedirectToPage("ViewPaintings");
            }
        }
    }


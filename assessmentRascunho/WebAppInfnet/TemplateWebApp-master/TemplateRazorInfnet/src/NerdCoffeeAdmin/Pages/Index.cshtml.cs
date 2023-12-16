using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Text;
using System.Text.Json;
using System;
using System.IO;
using System.Threading.Tasks;
using MeuMiniMuseu.Data.Models;

namespace MeuMiniMuseu.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<SurveyItem>surveyItems { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var conteudoJson = System.IO.File.ReadAllText("wwwroot/SampleData/survey.json");

            surveyItems = JsonSerializer.Deserialize<List<SurveyItem>>(conteudoJson);
        }
    }
}
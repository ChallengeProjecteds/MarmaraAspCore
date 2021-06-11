using MarmaraWeb.Models;
using MarmaraWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarmaraWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public JsonWikiService JsonWikiService;
        public WikiModel wikidata;

        public JsonProjectService JsonProjectService;
        public IEnumerable<ProjectModel> Projects;


        [BindProperty(SupportsGet =true)]
        public string Name { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Surname { get; set; }

        [BindProperty]
        public string Term { get; set; }
        [BindProperty]
        public string Extract { get; set; }
        [BindProperty]
        public string Title { get; set; }

        public IndexModel(ILogger<IndexModel> logger, JsonWikiService jsonwikiservice, JsonProjectService jsonprojectservice)
        {
            _logger = logger;
            JsonWikiService = jsonwikiservice;
            JsonProjectService = jsonprojectservice;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "Misafir";
                Extract= "Hayat fırsatlarla dolu bir yolculuk. Sen de bu yolculuğa katıl.";
                Title = "Merhaba";
            }

            Projects = JsonProjectService.GetProjects();
        }
        public void OnPost()
        {
            //Console.WriteLine(Term);
            //JsonService.GetWikiModel(Term);
            wikidata = JsonWikiService.GetWikiModel(Term);
            Extract = ExtractData(wikidata);
            Title = ExtractTitle(wikidata);

        }

        public string ExtractData(WikiModel wikidata)
        {
            string firstkey = wikidata.query.pages.First().Key;
            return wikidata.query.pages[firstkey].extract;
        }
        public string ExtractTitle(WikiModel wikidata)
        {
            string firstkey = wikidata.query.pages.First().Key;
            return wikidata.query.pages[firstkey].title;
        }

    }
}

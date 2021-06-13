using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarmaraWeb.Models;
using MarmaraWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MarmaraWeb.Pages
{
    public class odevlerModel : PageModel
    {

        public JsonDataService JsonDataService;

        public JsonProjectService JsonProjectService;
        public IEnumerable<ProjectModel> Projects;
        public IEnumerable<TestModel> testModels;
        public IEnumerable<SongModel> songData;


        public JsonWikiService JsonWikiService;
        public WikiModel wikidata;

        [BindProperty]
        public string Extract { get; set; }
        [BindProperty]
        public string Title { get; set; }
        [BindProperty]
        public string Term { get; set; }

        private readonly ILogger<odevlerModel> _logger;
        public odevlerModel(ILogger<odevlerModel> logger, JsonProjectService jsonprojectservice, JsonDataService jsondataservice, JsonWikiService jsonwikiservice)
        {
            _logger = logger;
            JsonWikiService = jsonwikiservice;
            JsonProjectService = jsonprojectservice;
            JsonDataService = jsondataservice;
        }

        public void OnGet()
        {
            Projects = JsonProjectService.GetProjects();
            testModels = JsonDataService.GetDataModels();
            songData = JsonDataService.GetDataModelSong();

        }
        public void OnPost()
        {
            Projects = JsonProjectService.GetProjects();
            if (string.IsNullOrWhiteSpace(Term))
            {

            }

            else
            {
                wikidata = JsonWikiService.GetWikiModel(Term);

                Extract = ExtractData(wikidata);
                if (string.IsNullOrWhiteSpace(Extract))
                    Extract = "Bulunamadý.";
                Title = ExtractTitle(wikidata);
            }

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

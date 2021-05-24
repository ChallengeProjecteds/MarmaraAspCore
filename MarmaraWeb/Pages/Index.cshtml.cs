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

        public JsonWikiService JsonService;

        private readonly ILogger<IndexModel> _logger;
        public WikiModel wikidata;
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

        public IndexModel(ILogger<IndexModel> logger, JsonWikiService jsonservice)
        {
            _logger = logger;
            JsonService = jsonservice;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "Misafir";
                Extract= "Hayat fırsatlarla dolu bir yolculuk. Sen de bu yolculuğa katıl.";
                Title = "Merhaba";
            }
        }
        public void OnPost()
        {
            Console.WriteLine(Term);
            //JsonService.GetWikiModel(Term);
            wikidata = JsonService.GetWikiModel(Term);
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

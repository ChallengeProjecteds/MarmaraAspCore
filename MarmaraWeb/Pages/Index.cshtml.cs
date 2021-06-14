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

        

        public JsonProjectService JsonProjectService;
        public JsonContentServices JsonContentService;
        public IEnumerable<ContentModel> Contents;
        public IEnumerable<CommunityModel> Communities;
        public IEnumerable<ProjectModel> Projects;

        public List<string> kategoriler = new List<string>();
        //public List<string> images = new List<string>();


        [BindProperty(SupportsGet =true)]
        public string Name { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Surname { get; set; }
        [BindProperty]
        public string Extract { get; set; }
        [BindProperty]
        public string Title { get; set; }



        public IndexModel(ILogger<IndexModel> logger,  JsonProjectService jsonprojectservice, JsonContentServices jsoncontentservice)
        {
            _logger = logger;
            
            JsonProjectService = jsonprojectservice;
            JsonContentService = jsoncontentservice;
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
            Contents = JsonContentService.GetContents();
            Communities = JsonContentService.GetCommunities();

            foreach (var item in Contents)
            {
                if(kategoriler.Contains(item.kategori))
                {

                }
                else
                {
                    kategoriler.Add(item.kategori);
                }
            }
        }
        public void OnPost()
        {
            
        }

        

    }
}

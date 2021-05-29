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
        public JsonProjectService JsonProjectService;
        public IEnumerable<ProjectModel> Projects;

        private readonly ILogger<odevlerModel> _logger;
        public odevlerModel(ILogger<odevlerModel> logger, JsonProjectService jsonprojectservice)
        {
            _logger = logger;
            JsonProjectService = jsonprojectservice;
        }

        public void OnGet()
        {
            Projects = JsonProjectService.GetProjects();
        }
    }
}

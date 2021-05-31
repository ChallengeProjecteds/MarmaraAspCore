using MarmaraWeb.Models;
using MarmaraWeb.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace MarmaraWeb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Project : ControllerBase
    {
        



        [HttpGet]
        public ActionResult<string> Get()
        {
            string url = "https://musicomm.azurewebsites.net/api/comments";
            string json = new WebClient().DownloadString(url);

            WikiModel wikimodel = JsonSerializer.Deserialize<WikiModel>(json);
            return wikimodel.ToString();
            

        }
    }
}

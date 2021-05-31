using MarmaraWeb.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace MarmaraWeb.Services
{
    
    

    public class JsonProjectService
    { 
        public JsonProjectService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }


        public IWebHostEnvironment WebHostEnvironment { get; }


        public string JsonFileName 
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "projects.json"); } 
        }

        public IEnumerable<ProjectModel>GetProjects() //dönüş değeri 1 tane değil de liste olacağı için IEnumerable türü kullanıldı.
        {



            var json = File.OpenText(JsonFileName);


            return JsonSerializer.Deserialize<ProjectModel[]>(json.ReadToEnd());
        }
    }
}

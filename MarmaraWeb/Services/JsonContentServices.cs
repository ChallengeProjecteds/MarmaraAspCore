using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarmaraWeb.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections;
using System.IO;
using System.Net;
using System.Text.Json;


namespace MarmaraWeb.Services
{
    public class JsonContentServices
    {
        public JsonContentServices(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }


        public string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "content.json"); }
        }

        public IEnumerable<ContentModel> GetContents() //dönüş değeri 1 tane değil de liste olacağı için IEnumerable türü kullanıldı.
        {

            var json = File.OpenText(JsonFileName);

            return JsonSerializer.Deserialize<ContentModel[]>(json.ReadToEnd());
        }



        public string JsonCommunityFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "community.json"); }
        }

        public IEnumerable<CommunityModel> GetCommunities() //dönüş değeri 1 tane değil de liste olacağı için IEnumerable türü kullanıldı.
        {

            var json = File.OpenText(JsonCommunityFileName);

            return JsonSerializer.Deserialize<CommunityModel[]>(json.ReadToEnd());
        }
    }
}

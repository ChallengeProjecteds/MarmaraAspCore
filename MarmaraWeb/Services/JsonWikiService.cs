using MarmaraWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace MarmaraWeb.Services
{
    public class JsonWikiService
    {
        //https://en.wikipedia.org/w/api.php?format=json&action=query&prop=extracts&exintro&explaintext&redirects=1&titles=g

        public WikiModel GetWikiModel(string term)
        {
            string url = string.Concat("https://en.wikipedia.org/w/api.php?format=json&action=query&prop=extracts&exintro&explaintext&redirects=1&titles=", term);
            string json = new WebClient().DownloadString(url);

            WikiModel wikimodel = JsonSerializer.Deserialize<WikiModel>(json); //aldığımız json'u ayrıştırıyoruz.


            return wikimodel;
        }
    }
}

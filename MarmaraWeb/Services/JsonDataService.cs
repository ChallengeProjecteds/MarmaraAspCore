using MarmaraWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace MarmaraWeb.Services
{
    public class JsonDataService
    {


        public TestModel GetDataModel()
        {
            string url = "https://musicomm.azurewebsites.net/api/comments";
            string json = new WebClient().DownloadString(url);

            //TestModel datamodel = JsonSerializer.Deserialize<TestModel>(json); //aldığımız json'u ayrıştırıyoruz.
            var datamodels = JsonSerializer.Deserialize<List<TestModel>>(json);
            TestModel data = datamodels.First();
            //return datamodel;
            return data;
        }

        public IEnumerable<TestModel> GetDataModels()
        {
            string url = "https://musicomm.azurewebsites.net/api/comments";
            string json;

            try
            {
                json = new WebClient().DownloadString(url);
            }
            catch (Exception)
            {
                return null;
            }
            
            return JsonSerializer.Deserialize<TestModel[]>(json);
        }










    }
}

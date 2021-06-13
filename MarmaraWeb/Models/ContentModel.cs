using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MarmaraWeb.Models
{
    public class ContentModel
    {
        public int id { get; set; }
        public string baslik { get; set; }
        public string icerik { get; set; }
        public string kategori { get; set; }
        public string tarih { get; set; }

        [JsonPropertyName("img")]
        public string image { get; set; }
        public string url { get; set; }

    }
}

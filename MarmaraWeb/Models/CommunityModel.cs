using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MarmaraWeb.Models
{
    public class CommunityModel
    {
        public int id { get; set; }
        public string baslik { get; set; }
        public string icerik { get; set; }

        [JsonPropertyName("img")]
        public string img { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarmaraWeb.Models
{
    public class SongModel
    {
        public int id { get; set; }
        public string category { get; set; }
        public string genre { get; set; }
        public string feeling { get; set; }
        public string energy { get; set; }
        public string duration { get; set; }
        public string url { get; set; }
    }
}

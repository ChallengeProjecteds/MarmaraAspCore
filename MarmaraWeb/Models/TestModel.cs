using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarmaraWeb.Models
{
    public class TestModel
    {
        //public Dictionary<string, pagevalue> pages { get; set; }

        public string commentId { get; set; }
        public string uid { get; set; }
        public string sender { get; set; }
        public string comment { get; set; }
        public string image { get; set; }
        public string createdAt { get; set; }
        public bool isSub { get; set; }
        public bool hasSub { get; set; }
        public string parentId { get; set; }


    }

}

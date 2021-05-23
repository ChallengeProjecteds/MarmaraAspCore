using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MarmaraWeb.Data;
using MarmaraWeb.Models;

namespace MarmaraWeb.Pages.Filmler
{
    public class IndexModel : PageModel
    {
        private readonly MarmaraWeb.Data.MarmaraWebContext _context;

        public IndexModel(MarmaraWeb.Data.MarmaraWebContext context)
        {
            _context = context;
        }

        public IList<Users> Users { get;set; }

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}

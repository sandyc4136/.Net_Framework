using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyWebApp2.Data;
using MyWebApp2.Models;

namespace MyWebApp2.Views.Depts
{
    public class IndexModel : PageModel
    {
        private readonly MyWebApp2.Data.MyDbContext _context;

        public IndexModel(MyWebApp2.Data.MyDbContext context)
        {
            _context = context;
        }

        public IList<Dept> Dept { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Depts != null)
            {
                Dept = await _context.Depts.ToListAsync();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GoreyRazorNedi.Data;
using GoreyRazorNedi.Models;

namespace GoreyRazorNedi.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly GoreyRazorNedi.Data.GoreyRazorNediContext _context;

        public IndexModel(GoreyRazorNedi.Data.GoreyRazorNediContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyFirstCoreWebApp.Data;
using MyFirstCoreWebApp.Models;

namespace MyFirstCoreWebApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MyFirstCoreWebApp.Data.MyFirstCoreWebAppContext _context;

        public IndexModel(MyFirstCoreWebApp.Data.MyFirstCoreWebAppContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}

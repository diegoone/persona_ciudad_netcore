using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using persona_ciudad.Data;

namespace persona_ciudad.Pages.Ubicacion
{
    public class IndexModel : PageModel
    {
        private readonly persona_ciudad.Data.ApplicationDbContext _context;

        public IndexModel(persona_ciudad.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Data.Ubicacion> Ubicacion { get;set; }

        public async Task OnGetAsync()
        {
            Ubicacion = await _context.Ubicaciones.ToListAsync();
        }
    }
}

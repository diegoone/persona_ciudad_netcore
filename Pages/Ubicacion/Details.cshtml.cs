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
    public class DetailsModel : PageModel
    {
        private readonly persona_ciudad.Data.ApplicationDbContext _context;

        public DetailsModel(persona_ciudad.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Data.Ubicacion Ubicacion { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ubicacion = await _context.Ubicaciones.FirstOrDefaultAsync(m => m.Codigo == id);

            if (Ubicacion == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

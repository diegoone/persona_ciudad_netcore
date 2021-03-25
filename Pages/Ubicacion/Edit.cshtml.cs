using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using persona_ciudad.Data;

namespace persona_ciudad.Pages.Ubicacion
{
    public class EditModel : PageModel
    {
        private readonly persona_ciudad.Data.ApplicationDbContext _context;

        public EditModel(persona_ciudad.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Ubicacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UbicacionExists(Ubicacion.Codigo))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool UbicacionExists(string id)
        {
            return _context.Ubicaciones.Any(e => e.Codigo == id);
        }
    }
}

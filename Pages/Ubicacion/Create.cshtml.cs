using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using persona_ciudad.Data;

namespace persona_ciudad.Pages.Ubicacion
{
    public class CreateModel : PageModel
    {
        private readonly persona_ciudad.Data.ApplicationDbContext _context;

        public CreateModel(persona_ciudad.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Data.Ubicacion Ubicacion { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Ubicaciones.Add(Ubicacion);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
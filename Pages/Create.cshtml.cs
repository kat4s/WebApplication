using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Model;
using WebApplication1.Data;

namespace WebApplication1.Pages.Shared
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;

        }
        public kdania Dania { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(kdania Dania)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Dania.Add(Dania);
           
            await _db.SaveChangesAsync();

            return RedirectToPage("strona");
        }
    }
}

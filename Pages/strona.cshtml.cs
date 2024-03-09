using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;
using WebApplication1.Data;


namespace WebApplication1.Pages
{
    public class aboutModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public aboutModel(ApplicationDbContext db)
        {
            _db = db;
            
        }
        public IList<kdania> Dania { get; set; }
        public async Task<IActionResult> OnGet()
        {
            Dania = await _db.Dania.ToListAsync();
            return Page();
        }
        public async Task <IActionResult> OnPostDelete(int id)
        {
            var dania = await _db.Dania.FindAsync(id);
            if(dania==null)
            {
                return NotFound();
            }
            _db.Dania.Remove(dania);
            await _db.SaveChangesAsync();
            return RedirectToPage("strona");
        }
        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Model;
using WebApplication1.Data;
namespace WebApplication1.Pages
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;
     
        public EditModel(ApplicationDbContext db)
        { _db = db; }

        [BindProperty]
        public kdania Dania {set;get;}
        public void OnGet(int id)
        {
            Dania = _db.Dania.Find(id);
        }
        public async Task<IActionResult> OnPost()
        {
            var Carfdb = await _db.Dania.FindAsync(Dania.id);

            Carfdb.Nazwa = Dania.Nazwa;
            Carfdb.Przepis = Dania.Przepis;
            Carfdb.Zdj = Dania.Zdj;
            await _db.SaveChangesAsync();
            return RedirectToPage("strona");


        }
    }
}

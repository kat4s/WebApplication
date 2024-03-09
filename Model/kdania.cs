using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class kdania
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name ="Nazwa")]
        public string Nazwa { get; set; }
        [Display(Name = "Trudnosc")]
        public string Trudnosc { get; set; }
        [Display(Name = "Przepis")]
        public string Przepis { get; set; }
        [Display(Name = "Zdj")]
        public string Zdj { get; set; }
    }
}

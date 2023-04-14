using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab3.Models;

namespace lab3.Pages_Profile
{
    public class DetailsModel : PageModel
    {
        private readonly Lab3.Models.Lab3Context _context;

        public DetailsModel(Lab3.Models.Lab3Context context)
        {
            _context = context;
        }

      public LabUser LabUser { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync()
        {
            int? id = 1;
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var labuser = await _context.Users.FirstOrDefaultAsync(m => m.LabUserId == id);
            if (labuser == null)
            {
                return NotFound();
            }
            else 
            {
                LabUser = labuser;
            }
            return Page();
        }
    }
}

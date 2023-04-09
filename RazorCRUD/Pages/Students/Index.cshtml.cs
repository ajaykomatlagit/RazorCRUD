using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCRUD.Data;
using RazorCRUD.Model;

namespace RazorCRUD.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly RazorCRUD.Data.RazorCRUDContext _context;

        public IndexModel(RazorCRUD.Data.RazorCRUDContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student.ToListAsync();
            }
        }
    }
}

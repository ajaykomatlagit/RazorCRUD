using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorCRUD.Model;

namespace RazorCRUD.Data
{
    public class RazorCRUDContext : DbContext
    {
        public RazorCRUDContext (DbContextOptions<RazorCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<RazorCRUD.Model.Student> Student { get; set; } = default!;
    }
}

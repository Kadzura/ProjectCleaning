using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Security.Policy;
using ProjectCleaning.Models;
using System.Data.Entity.Infrastructure;

namespace ProjectCleaning.Context 
{
    internal class CleaningContextDb : DbContext
    {
        public static CleaningContextDb _context;

        public CleaningContextDb() : base("DefaultConnection")
        {

        }

        public static CleaningContextDb GetComponent()
        {
            if (_context == null)
            {
                _context = new CleaningContextDb();
            }
            return _context;
        }

        public DbSet<PositionClass> Positions { get; set; }
        public DbSet<PersonClass> Persons { get; set; }
    }
}

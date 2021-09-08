using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Requests> Requests { get; set; }
        public DbSet<Access> Access { get; set; }
        public DbSet<Vacation> Vacation { get; set; }
        public DbSet<Things_to_borrow> Things_To_Borrow { get; set; }
        public DbSet<Hint> Hints { get; set; }
        public DbSet<Healthcheck> HealthCheck {get;set;}
        public DbSet <Children> Children { get; set; }
        public DbSet<Borrower> Borrower { get; set; }
     




    }
}
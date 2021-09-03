using Microsoft.EntityFrameworkCore;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Company> Company { get; set; }
        public DbSet<EstonianOffice> EstonianOffice { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Child> Child { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<HealthControll> HealthControll { get; set; }
        public DbSet<Vacation> Vacation { get; set; }

    }
}
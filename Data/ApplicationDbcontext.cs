using Microsoft.EntityFrameworkCore;
using PMTBaiThiLai.Models;
using PMTBaiThiLai;

namespace PMTBaiThiLai.Data{
    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<Person>Person {get;set;}
    }
}
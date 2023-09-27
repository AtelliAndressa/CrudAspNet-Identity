using CrudTest.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CrudTest.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    //Relação entre aplicação e db.
    public DbSet<Student> Students { get; set; } = default!;
    public DbSet<Premium> Premiums { get; set; } = default!;
}

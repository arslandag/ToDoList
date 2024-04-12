using Microsoft.EntityFrameworkCore;
using ToDoList.Core.Models;

namespace ToDoList.Persistence;
public class ToDoListDbContext : DbContext
{
    public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options)
        : base(options)
    {   
    }
    public DbSet<Target> Targets { get; set; }
}

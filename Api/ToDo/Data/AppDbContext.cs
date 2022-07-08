using Microsoft.EntityFrameworkCore;
using ToDo.Models;

namespace ToDo.Data{
    public class AppDbContext : DbContext {
        public DbSet<ToDoModels> ToDos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        => options.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}
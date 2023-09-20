using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext : DbContext // Don't forget to install 'EntityFrameworkCore'
    {
        /**
         * When working with Entity Framework Core, there are two approaches:
         * 
         * 1. Code First Approach (this is what we're using) - we are writing the code of
         * our model and based on this model, we will be creating the database.
         * 
         * 2. Database First Approach - database is already created and based on this database,
         * you will be scaffolding models.
         * 
         * Package Manager Console Commands:
         * 1. 'Add-Migration' = keeping a track of all database changes that are needed.
         * Notes: 
         * - To enable migrations, install 'Microsoft.EntityFrameworkCore.Tools' first.
         * - Do not use any spaces when writing the name of the migration.
         * 
         * 2. 'Update-Database' = push the migrations to the database.
         * 
         */

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // For every model in your project, you need to create a DbSet
        public DbSet<Category> Categories { get; set; }
    }
}

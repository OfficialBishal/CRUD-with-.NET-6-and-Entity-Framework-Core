using System;
using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Code First Model
        public DbSet<Category> Categories { get; set; }
    }
}

//PackageManagerConsole
//EF Core Tool - Nuget
//add-migration AddCategoryToDatabase
//update-database


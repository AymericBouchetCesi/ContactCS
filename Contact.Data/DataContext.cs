using System;
using System.Collections.Generic;
using System.Text;
using Contact.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Contact.Data
{
	public class DataContext : DbContext
	{
		public DbSet<Person> people { get; set; }

		public DataContext()
		{
			Database.EnsureDeleted();
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
		{
			//string path = @"C:\person.db3";
			optionsBuilder.UseSqlite($"Filename=person.db3");

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder) 
		{
			modelBuilder.Entity<Person>().HasData(
				new Person { Id = 1, Name = "Frédéric" },
				new Person { Id = 2, Name = "Dylan" },
				new Person { Id = 3, Name = "Jordan" },
				new Person { Id = 4, Name = "Bob" }
				);
		}
	}
}

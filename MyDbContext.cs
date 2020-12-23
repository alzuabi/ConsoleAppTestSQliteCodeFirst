using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Common;

namespace ConsoleApp2
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("TestDb") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ModelConfiguration.Configure(modelBuilder);
            var initializer = new TestDbInitializer(modelBuilder);
            Database.SetInitializer(initializer);
        }

        public DbSet<Person> Persons { get; set; }

    }
    public class ModelConfiguration
    {
        public static void Configure(DbModelBuilder modelBuilder)
        {
            ConfigurePersonEntity(modelBuilder);

        }


        private static void ConfigurePersonEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>();
        }
    }
     
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TaskManager.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TaskManager.Context
{
    public class Assignmentcontext : DbContext
    {
        public Assignmentcontext() : base("Assignmentcontext")
        {
            Database.SetInitializer<Assignmentcontext>(new CreateDatabaseIfNotExists<Assignmentcontext>());
        }
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Assignment> Assignments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
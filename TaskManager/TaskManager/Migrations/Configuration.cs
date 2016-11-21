namespace TaskManager.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TaskManager.Context.Assignmentcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TaskManager.Context.Assignmentcontext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var Consultants = new List<Consultant>
            {
            new Consultant{Consultant_Id=1,Consultant_Name="Anderas Anderson"},
            new Consultant{Consultant_Id=2,Consultant_Name="Johan Johanson"},
            new Consultant{Consultant_Id=3,Consultant_Name="Rohet Sharma"},
            new Consultant{Consultant_Id=4,Consultant_Name="Roula AlHaddad"},
            };
            Consultants.ForEach(s => context.Consultants.Add(s));
            context.SaveChanges();

            var Assignments = new List<Assignment>
            {
            new Assignment{Assignment_Id=1,Assignment_Name="T&M",Client="E.ON",Percentage="100%",Start_date=DateTime.Parse("2016-05-21"),End_date=DateTime.Parse("2016-12-01"),Comment="A",Consultant_Id=1},
            new Assignment{Assignment_Id=2,Assignment_Name="Payments",Client="IKEA",Percentage="100%",Start_date=DateTime.Parse("2016-05-21"),End_date=DateTime.Parse("2017-09-01"),Comment="B",Consultant_Id=2},
            new Assignment{Assignment_Id=3,Assignment_Name="Public web",Client="ALFA LAVA",Percentage="50%",Start_date=DateTime.Parse("2015-05-15"),End_date=DateTime.Parse("2017-12-01"),Comment="C",Consultant_Id=3},
            new Assignment{Assignment_Id=4,Assignment_Name="Intranet",Client="IKEA",Percentage="50%",Start_date=DateTime.Parse("2016-05-15"),End_date=DateTime.Parse("2016-12-01"),Comment="A",Consultant_Id=3},
            };
            Assignments.ForEach(s => context.Assignments.Add(s));
            context.SaveChanges();
        }
    }
}

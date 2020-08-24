namespace ModelBind1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ModelBind1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ModelBind1.Models.StudentModels>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ModelBind1.Models.StudentModels context)
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

            context.students.AddOrUpdate(new Student
                {
                    Firstname = "Gunwant",
                    Lastname = "Kapade",
                    Email = "gunwant1995@gmail.com",
                    year = Academic.Junior
                },
                new Student
                {
                    Firstname = "Amar",
                    Lastname = "Kapade",
                    Email = "gunwant19@gmail.com",
                    year = Academic.Senior
                },
                new Student
                {
                    Firstname = "Shayam",
                    Lastname = "Rana",
                    Email = "Shayam@example.com",
                    year = Academic.Senior
                },
                new Student
                {
                    Firstname = "Jecub",
                    Lastname = "Cunto",
                    Email = "Nino@example.com",
                    year = Academic.Freshman
                }
            );

            context.SaveChanges();
           /* context.Course.AddOrUpdate(
                new Enrollment { StudentID = 1, Grade = 1 }
                );
            context.SaveChanges(); */
        }
    }
}

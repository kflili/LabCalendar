namespace LabCalendar.Migrations
{
    using LabCalendar.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LabCalendar.DAL.LabContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LabCalendar.DAL.LabContext context)
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

            var events = new List<Event>
            {
                new Event
                {
                    Subject = "Athena",
                    Description = "Magnetism measurement",
                    Start = DateTime.Parse("2017-07-15 9:00 AM"),
                    ThemeColor = "red",
                    IsFullDay = true
                },

                new Event
                {
                    Subject = "Drew",
                    Description = "Resistance measurement",
                    Start = DateTime.Parse("2017-07-17 9:00 AM"),
                    End = DateTime.Parse("2017-07-17 9:00 AM"),
                    ThemeColor = "green",
                    IsFullDay = false
                }
            };
            events.ForEach(e => context.Events.AddOrUpdate(p => p.Subject, e));
            context.SaveChanges();
        }
    }
}

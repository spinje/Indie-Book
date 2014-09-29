namespace Indie_Book.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Indie_Book.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            // Changed to true 2014-09-25
            AutomaticMigrationsEnabled = true;
            // Added 2014-09-29
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Indie_Book.Models.ApplicationDbContext context)
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
        }
    }
}

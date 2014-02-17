namespace Itec_Project.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Itec_Project.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0");
        }

        protected override void Seed(Itec_Project.Models.DataContext context)
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

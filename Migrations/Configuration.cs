namespace Roller.Migrations
{
    using Roller.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Roller.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Roller.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.MembershipTypes.AddOrUpdate(
              p => p.DiscountRate,
              new MembershipType { signUpFee = 200, DurationInMonths = 6, DiscountRate = 10 }

            );
            context.Customers.AddOrUpdate(
              p => p.Name,
              new Customer { Name = "Abubkar", SubscribeToNewsLetter = false, MembershipTypeId = 1 },
               new Customer { Name = "Kaka", SubscribeToNewsLetter = true, MembershipTypeId = 1 }
            );
        }
    }
}

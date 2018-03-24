namespace FriendOrganizer.DataAccess.Migrations
{
    using FriendOrganizer.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizer.DataAccess.FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizer.DataAccess.FriendOrganizerDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.+
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Friend() { FirstName = "Jesus", LastName = "Dicent" },
                new Friend() { FirstName = "Carlos", LastName = "Rodriguez" },
                new Friend() { FirstName = "Lucero", LastName = "Albares" },
                new Friend() { FirstName = "Pedro", LastName = "Almonte" }
                );

        }
    }
}

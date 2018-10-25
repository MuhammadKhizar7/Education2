using Education2.Models;

namespace Education2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Education2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Education2.Models.ApplicationDbContext";
        }

        protected override void Seed(Education2.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Books.AddOrUpdate(x => x.Id,
                new Book()
                {
                    Id = 1,
                    Title = "Pride and Prejudice",
                   
                    Description = "Comedy of manners"
                },
                new Book()
                {
                    Id = 2,
                    Title = "Northanger Abbey",
                   
                    Description = "Gothic parody"
                },
                new Book()
                {
                    Id = 3,
                    Title = "David Copperfield",

                    Description = "Bildungsroman"
                },
                new Book()
                {
                    Id = 4,
                    Title = "Don Quixote",

                    Description = "Picaresque"
                }
            );
        }
    }
}

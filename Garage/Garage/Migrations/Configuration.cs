namespace Garage.Migrations
{
    using Garage.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Garage.CarContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Garage.CarContext context)
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

            Make bmw = new Make()
            {
                MakeName="BMW", 
                Models=new List<CarModel>(){
                    new CarModel(){CarModelName="318"}, 
                    new CarModel(){CarModelName="520"}
                }};

            context.Makes.AddOrUpdate(bmw);

            Make opel = new Make()
            {
                MakeName = "Opel",
                Models = new List<CarModel>(){
                    new CarModel(){CarModelName="Astra"}, 
                    new CarModel(){CarModelName="Vectra"}
                }
            };

            context.Makes.AddOrUpdate(opel);
        }
    }
}

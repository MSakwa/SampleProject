namespace SampleProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SampleProject.DAL.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SampleProject.DAL.ApplicationContext context)
        {
            if(context.Persons.Count() == 0)
            {
                var vrlNewPersons = new Utilities.NamesGenerator().GetRandomPersons();
                context.Persons.AddRange(vrlNewPersons);
                context.SaveChanges();
            }
        }
    }
}

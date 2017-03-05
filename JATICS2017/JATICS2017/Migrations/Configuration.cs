namespace JATICS2017.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JATICS2017.Model.DataModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //CODIGO QUE SE DEBE ACTIVAR PARA CUANDO SE TRABAJAR CON UN SERVIDOR MYSQL 
            SetSqlGenerator("MySql.Data.MySqlClient",
                new MySql.Data.Entity.MySqlMigrationSqlGenerator());
        }

        protected override void Seed(JATICS2017.Model.DataModel context)
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

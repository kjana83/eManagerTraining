using eManager.Domain;

namespace eManager.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<eManager.Web.Infrastructure.DepartmentDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(eManager.Web.Infrastructure.DepartmentDb context)
        {
            context.Departments.AddOrUpdate(p => p.Name,
                new Department() { Name = "Insurance" },
                 new Department() { Name = "Retail" },
                 new Department() { Name = "Bank" });
        }
    }
}

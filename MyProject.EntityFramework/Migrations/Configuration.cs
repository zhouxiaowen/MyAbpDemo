using System.Data.Entity.Migrations;

namespace MyProject.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MyProject.EntityFramework.MyProjectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;       //设置此处才能直接更新到数据库
            ContextKey = "MyProject";
        }

        protected override void Seed(MyProject.EntityFramework.MyProjectDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...

        }
    }
}

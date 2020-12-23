using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class TestDbInitializer : SqliteDropCreateDatabaseWhenModelChanges<MyDbContext>
    {
        public TestDbInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder)
        { }

        protected override void Seed(MyDbContext context)
        {
            // Here you can seed your core data if you have any.
        }
    }
}

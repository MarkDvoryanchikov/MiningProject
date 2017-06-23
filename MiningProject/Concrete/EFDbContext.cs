using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MiningProject.Models;

namespace MiningProject.Concrete
{
    class EFDbContext: DbContext
    {
        //Автосоздание таблиц по объектной модели c sqlite. Разобраться!
        //public EFDbContext() : base("EFDbContext")
        //{
        //    Database.SetInitializer(
        //        new DropCreateDatabaseIfModelChanges<EFDbContext>());
        //    Database.ExecuteSqlCommand("CREATE TABLE [Tasks]( [PK_Task] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,[TaskName] TEXT NOT NULL); ");
        //}

        public DbSet<MyTask> MyTasks { get; set; }
        public DbSet<Layer> Layers { get; set; }
        public DbSet<Calc> Calcs { get; set; }
        public DbSet<LayersCalculation> LayersCaculations { get; set; }
    }
}

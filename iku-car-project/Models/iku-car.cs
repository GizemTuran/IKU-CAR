using System;
using System.Data.Entity;
using System.Linq;

namespace iku_car_project.Models
{
    public class iku_car : DbContext
    {
        public iku_car()
            : base("name=iku-car")
        {
        }
        public DbSet<Car> Cars { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
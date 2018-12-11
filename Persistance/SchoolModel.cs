namespace Persistance
{
    using Core;
    using System.Data.Entity;
    
    public class SchoolModel : DbContext
    {
        // Your context has been configured to use a 'SchoolModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Persistance.SchoolModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SchoolModel' 
        // connection string in the application configuration file.
        public SchoolModel()
            : base("name=SchoolModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
    }
}
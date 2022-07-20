using HW15.DbModels;

namespace HW15
{
    class Program
    { 
        static void Main(string[] args)
        {
            using (ApplicationContext context = new ApplicationContextFactory().CreateDbContext(Array.Empty<string>())) 
            {
                context.Database.EnsureCreated();
                Project project1 = new Project { Name = "Company", Budget = 1000.0M, StartedDate = new DateTime(2015, 7, 20), ClientId = 5 };
                context.Projects.Add(project1);
                context.SaveChanges();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentgingContext())
            {
                // Create and save a new Student
                Console.Write("Enter a name for a new student: ");
                var name = Console.ReadLine();

                var Student = new Student { Name = name };
                db.Students.Add(Student);
                db.SaveChanges();

                // Display all Students from the database
                var query = from b in db.Students
                            orderby b.Name
                            select b;

                Console.WriteLine("All Students in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public virtual List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }

    public class StudentgingContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
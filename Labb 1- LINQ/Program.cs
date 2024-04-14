//Christian Rapp SUT23
using Labb_1__LINQ.data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Labb_1__LINQ
{
    internal class Program
    {


        static void Main(string[] args)
        {
            using (var context = new EducationContext())
            {
                var mathTeachers = context.Teachers
                                          .Where(t => t.Subjects.Any(s => s.Name == "Matematik"))
                                          .ToList();

                foreach (var teacher in mathTeachers)
                {
                    Console.WriteLine($"Lärare: {teacher.Name}");
                }
            }
            Console.ReadKey();
            Console.WriteLine("-----------------------");
            using (var context = new EducationContext())
            {
                var query = from s in context.Students
                            join t in context.Teachers on s.TeacherId equals t.TeacherID
                            select new { StudentName = s.Name, TeacherName = t.Name };

                var result = query.ToList();

                foreach (var item in result)
                {
                    Console.WriteLine($"Student: {item.StudentName}, Lärare: {item.TeacherName}");
                }
            }
            Console.ReadKey();
            Console.WriteLine("-----------------------");
            using (var context = new EducationContext())
            {
                var containsProgramming1 = (from s in context.Subjects
                                            where s.Name == "Programmering1"
                                            select s).Any();

                Console.WriteLine($"Finns 'Programmering1' i ämnen: {containsProgramming1}");
            }
            Console.ReadKey();
            
            // änndra ämne
            using (var context = new EducationContext())
            {
               
                var subject = context.Subjects.FirstOrDefault(s => s.Name == "OOP");
                if (subject != null)
                {
                    
                    subject.Name = "Programmering2";
                    context.SaveChanges();
                    Console.WriteLine("Ämnet har uppdaterats till 'Programmering2'.");
                }
                else
                {
                    Console.WriteLine("Ämnet 'Programmering2' hittades inte.");
                }
            }
            Console.WriteLine("-----------------------");
            Console.ReadKey();
            // byta namn på lärare, dock finns ingen Anas ;'(
            using (var context = new EducationContext())
            {
                
                var anas = context.Teachers.FirstOrDefault(t => t.Name == "Anna Svensson");
                
                var reidar = context.Teachers.FirstOrDefault(t => t.Name == "Reidar");

                if (anas != null && reidar != null)
                {
                    
                    var students = context.Students.Where(s => s.TeacherId == anas.TeacherID).ToList();
                    foreach (var student in students)
                    {
                        
                        student.TeacherId = reidar.TeacherID;
                    }
                    context.SaveChanges();
                    Console.WriteLine("Alla relevanta studentposter har uppdaterats.");
                }
                else
                {
                    Console.WriteLine("En eller båda lärarna kunde inte hittas.");
                }
            }
            Console.WriteLine("-----------------------");
            Console.ReadKey();


        }
    }
}

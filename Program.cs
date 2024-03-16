using ConsoleApp.Database;
using ConsoleApp.Database.Manager;
using ConsoleApp.Models;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {

            string connectionString = "Server=VLADLENPC\\SQLEXPRESS;Database=testdatabase;Integrated Security=True;TrustServerCertificate=True;";
            DatabaseContext dbContext = new DatabaseContext(connectionString);

            UserRepository userRepository = new UserRepository(dbContext);
            TaskRepository taskRepository = new TaskRepository(dbContext);

            TaskModel task1 = new TaskModel
            {
                Title = "Задача 1",
                Description = "Описание задачи 1",
                DueDate = DateTime.Now.AddDays(3)
            };
            taskRepository.Create(task1);
            
            /*
            dbContext.Tasks.Add(task1);
            dbContext.SaveChanges();
            */
            TaskModel retrievedTask = taskRepository.GetById(1);
            
            // TaskModel retrievedTask = dbContext.Tasks.FirstOrDefault(t => t.Id == 1);
            
            if (retrievedTask != null)
            {
                Console.WriteLine($"Найденная задача: {retrievedTask.Title}");
            }

            UserModel user1 = new UserModel
            {
                Name = "Иван",
                Email = "ivan@example.com"
            };
            userRepository.Create(user1);

            /*
            dbContext.Users.Add(user1);
            dbContext.SaveChanges();
            */

            UserModel retrievedUser = userRepository.GetById(1);
           
            // UserModel retrievedUser = dbContext.Users.FirstOrDefault(u => u.Id == 1);

            if (retrievedUser != null)
            {
                Console.WriteLine($"Найденный пользователь: {retrievedUser.Name}");
            }
        }
    }
}

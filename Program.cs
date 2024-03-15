namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {

            string connectionString = "Server=VLADLENPC\\SQLEXPRESS;Database=testdatabase;Integrated Security=True;TrustServerCertificate=True;";
            DatabaseContext dbContext = new DatabaseContext(connectionString);

            TaskModel task1 = new TaskModel
            {
                Title = "Задача 1",
                Description = "Описание задачи 1",
                DueDate = DateTime.Now.AddDays(3)
            };
            dbContext.Tasks.Add(task1);
            dbContext.SaveChanges();

            TaskModel retrievedTask = dbContext.Tasks.FirstOrDefault(t => t.Id == 1);
            if (retrievedTask != null)
            {
                Console.WriteLine($"Найденная задача: {retrievedTask.Title}");
            }

            UserModel user1 = new UserModel
            {
                Name = "Иван",
                Email = "ivan@example.com"
            };
            dbContext.Users.Add(user1);
            dbContext.SaveChanges();

            UserModel retrievedUser = dbContext.Users.FirstOrDefault(u => u.Id == 1);
            if (retrievedUser != null)
            {
                Console.WriteLine($"Найденный пользователь: {retrievedUser.Name}");
            }
        }
    }
}

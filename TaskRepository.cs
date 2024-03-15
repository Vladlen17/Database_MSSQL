using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class TaskRepository : IDatabaseRepository<TaskModel>
    {
        private readonly DatabaseContext _dbContext;

        public TaskRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(TaskModel task)
        {
            _dbContext.Tasks.Add(task);
            _dbContext.SaveChanges();
        }

        public TaskModel GetById(int id)
        {
            return _dbContext.Tasks.FirstOrDefault(t => t.Id == id);
        }

        public void Update(TaskModel task)
        {
            _dbContext.Tasks.Update(task);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var task = _dbContext.Tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                _dbContext.Tasks.Remove(task);
                _dbContext.SaveChanges();
            }
        }
    }
}
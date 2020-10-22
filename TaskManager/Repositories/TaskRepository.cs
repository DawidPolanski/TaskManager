using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public TaskModel Get(int taskId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TaskModel> GetAllActivie()
        {
            throw new NotImplementedException();
        }

        public void Add(TaskModel task)
        {
            throw new NotImplementedException();
        }

        public void Update(int taskId, TaskModel task)
        {
            throw new NotImplementedException();
        }


        public void Delete(int taskId)
        {
            throw new NotImplementedException();
        }
    }
}

using to_do_list.src.Models;

namespace to_do_list.src.Repositries
{
    // Логіка для роботи з json об'єктом з завданнями
    public interface ITaskRepository
    {
        public bool CreateTask(MyTask task);
        public bool DeleteTask(MyTask task);
        public bool UpdateTask(MyTask task);
        public List<MyTask> GetAllTasks();
        public bool DeleteAllTasks();
        public List<string> GetTasksNames();
        public List<MyTask> GetCompletedTasks();
        public MyTask GetTaskByName(string name);
        public List<MyTask> GetTasksByName(string name);
        
    }
}

using to_do_list.src.Models;

namespace to_do_list.src.Services
{
    //Описання основної логіки роботи з репозиторієм
    public interface ITaskService
    {
        //Отримання всіх завдань для відображення.
        public (List<MyTask>, List<MyTask>) GetTaskForStart();
        //змінення періоду часу даного на виконання
        public MyTask EditTaskTime(MyTask task);
        public bool CreateTask(MyTask task);
        public bool DeleteTask(MyTask task);
        public bool UpdateTask(MyTask task);
        public List<MyTask> GetAllTasks();
        public bool DeleteAllTasks();
        public MyTask GetTaskByName(string name);
        public List<MyTask> FindTask(string name);
    }
}

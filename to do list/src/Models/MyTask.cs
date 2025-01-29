namespace to_do_list.src.Models
{
    public class MyTask
    {
        // Унікальний ідентифікатор задачі
        public int Id { get; set; }

        // Назва задачі
        public string Title { get; set; }

        // Опис задачі
        public string Description { get; set; }

        // Статус задачі (завершена чи ні)
        public bool IsCompleted { get; set; }

        // Дата створення задачі
        public DateTime CreatedAt { get; set; }
        
        // Час активності задачі
        public TimeSpan TimeSpan { get; set; }

        // Дата останнього оновлення
        public DateTime UpdatedAt { get; set; }

        // Конструктор для ініціалізації задачі
        public MyTask(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
            IsCompleted = false;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            DateTime createdAt = DateTime.Now;
        }

        // Метод для відмітки задачі як виконаної
        public void MarkAsCompleted()
        {
            IsCompleted = true;
            UpdatedAt = DateTime.Now;
        }

        // Метод для відновлення задачі (якщо була відзначена як виконана)
        public void Restore()
        {
            IsCompleted = false;
            UpdatedAt = DateTime.Now;
        }
    }
}

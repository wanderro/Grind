public class TodoList
{
    private List<Task> _tasks = new List<Task>();
    public int Count = 1;
    public int CountOfCompletedTasks = 0;

    public void Add()
    {
        Task task = new Task();
        Console.Write("Введите название задания: ");
        task.Name = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Введите награду за задание: ");
        task.Cost = Convert.ToInt32(Console.ReadLine());

        _tasks.Add(task);
        Console.WriteLine();
    }

    public void CompletedTask()
    {
        if (_tasks.Count <= 0)
        {
            Console.WriteLine("Нет заданий!");
            Console.WriteLine();
            return;
        }

        Console.Write("Введите номер задания, которое хотите выполнить: ");
        int count = Convert.ToInt32(Console.ReadLine()) - 1;

        CountOfCompletedTasks++;
        Level.AddXP(_tasks[count].Cost);
        _tasks.RemoveAt(count);
        Console.WriteLine();

        Console.WriteLine("Задание выполнено!");
        Console.WriteLine();
    }


    public void PrintTasks()
    {
        if (_tasks.Count <= 0)
        {
            Console.WriteLine("Нет заданий!");
            Console.WriteLine();
            return;
        }
        
        
        Count = 1;
        foreach (var task in _tasks)
        {
            Console.WriteLine($"№.Задания: {Count} Имя задания: {task.Name} Стоимость задания: {task.Cost}");
            Count++;
        }

        Console.WriteLine();
    }

    public void DeleteTask()
    {
        if (_tasks.Count <= 0)
        {
            Console.WriteLine("Нет заданий!");
            Console.WriteLine();
            return;
        }

        Console.Write("Введите номер задания, которое хотите удалить: ");
        var count = Convert.ToInt32(Console.ReadLine()) - 1;

        _tasks.RemoveAt(count);
        Console.WriteLine();

        Console.WriteLine("Задание удалено!");
        Console.WriteLine();
    }
}
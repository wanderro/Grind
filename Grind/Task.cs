public class Task
{
    public Dictionary<string, int> Tasks = new Dictionary<string, int>();
    public int Count = 1;
    public Dictionary<int, string> TempTasks = new Dictionary<int, string>();
    public int CountOfCompletedTasks = 0;

    public void Add()
    {
        Console.Write("Введите название задания: ");
        string taskName = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Введите награду за задание: ");
        int taskCost = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Tasks.Add(taskName, taskCost);
        TempTasks.Add(Count,taskName);
        Count++;

    }

    public void CompletedTask()
    {
        if (!TempTasks.ContainsKey(1))
        {
            Console.WriteLine("Нет заданий!");
            return;
        }
        Console.Write("Введите номер задания, которое хотите выполнить: ");
        int count = Convert.ToInt32(Console.ReadLine());
        
        string nameOfTask = TempTasks[count];
        Level.AddXP(Tasks[nameOfTask]);
        Tasks.Remove(nameOfTask);
        Console.WriteLine();
        CountOfCompletedTasks++;

        Console.WriteLine("Задание выполнено!");
        Console.WriteLine();
    }
    

    public void PrintTasks()
    {
        Count = 1;
        foreach (var keyValuePair in Tasks)
        {
            Console.WriteLine($"№.Задания: {Count}, Имя задания: {keyValuePair.Key}, Стоимость задания: {keyValuePair.Value}");
            if (!TempTasks.ContainsValue(keyValuePair.Key) && !TempTasks.ContainsKey(Count))
            {
                TempTasks.Add(Count, keyValuePair.Key);
            }
            Count++;
        }
        Console.WriteLine();

    }

    public void DeleteTask()
    {
        if (!TempTasks.ContainsKey(1))
        {
            Console.WriteLine("Нет заданий!");
            return;
        }
        Console.Write("Введите номер задания, которое хотите удалить: ");
        int count = Convert.ToInt32(Console.ReadLine());
        string nameOfTask = TempTasks[count];
        Tasks.Remove(nameOfTask);
        Console.WriteLine();

        Console.WriteLine("Задание удалено!");
        Console.WriteLine();
    }
}
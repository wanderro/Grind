public class User
{
    private string _username;
    private string _password;
    public bool Login = false;
    public Task Task = new Task();
    public bool IsBanned = false;

    public void CurrentLevelInformation()
    {
        
    }

    public void Start(User user)
    {
        Menu menu = new Menu();
        menu.Start(user);
    }

    public void RegisterAccount()
    {
        Console.Write("Введите ваше имя: ");
        _username = Console.ReadLine();
        Console.WriteLine("\n Имя сохранено. \n");

        Console.Write("Придумайте ваш пароль: ");
        _password = Console.ReadLine();
        Console.WriteLine("\n Пароль сохранен. \n");
    }

    public void Authorization()
    {
        if (!Login && !IsBanned)
        {
            for (int i = 5 - 1; i >= 0; i--)
            {
                Console.Write("Введите ваше имя: ");
                string username = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Введите ваш пароль: ");
                string password = Console.ReadLine();
                Console.WriteLine();

                if (username == _username && password == _password)
                {
                    Console.WriteLine("Вы успешно авторизовались! \n");
                    Login = true;
                    return;
                }
                else
                {
                    Console.WriteLine($"Ошибка авторизации! Осталось {i} попытки \n");
                }
            }

            Console.WriteLine("Вы заблокированы!");
            IsBanned = true;
        }
    }

    public void LogOut()
    {
        Login = false;
    }

    public void AddTask()
    {
        Task.Add();
    }

    public void ChangePassword()
    {
        bool isRightPassword = true;
        while (!isRightPassword)
        {
            Console.Write("Введите старый пароль: ");
            string password = Console.ReadLine();
            Console.WriteLine();

            if (password != _password)
            {
                Console.WriteLine("Пароль неверный! Повторите попытку!");
                isRightPassword = false;
            }
            else
            {
                if (password == _password)
                {
                    Console.Write("Введите новый пароль: ");
                    string newPassword = Console.ReadLine();
                    _password = newPassword;
                    Console.WriteLine("\n Пароль успешно изменён!");
                    isRightPassword = true;
                }
            }
        }
    }
}
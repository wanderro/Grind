public class User
{
    private string _username;
    private string _password;
    private bool _isRegistered;
    protected internal bool Login = false;
    protected internal TodoList TodoList = new TodoList();
    protected internal bool IsBanned = false;

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
        if (_isRegistered)
        {
            Console.WriteLine("Вы уже зарегестрированы!");
            return;
        }
        Console.Write("Введите ваше имя: ");
        _username = Console.ReadLine();
        Console.WriteLine("Имя сохранено.");

        Console.Write("Придумайте ваш пароль: ");
        _password = Console.ReadLine();
        Console.WriteLine("Пароль сохранен.");
        Console.WriteLine("\n Вы успешно зарегестрировались! \n");

        _isRegistered = true;
    }

    public void Authorization()
    {
        if (!_isRegistered)
        {
            Console.WriteLine("Пожалуйста, зарегестрируйтесь!");
            RegisterAccount();
            return;
        }
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
                    Console.WriteLine($"Ошибка авторизации! Осталось {i} попытки(-ок) \n");
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
        TodoList.Add();
    }

    public void ChangePassword()
    {
        bool isRightPassword = false;
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
                    Console.WriteLine("\n Пароль успешно изменён! \n");
                    isRightPassword = true;
                }
            }
        }
    }
}
public class Menu
{
    private User _thisUser;

    public void Start(User user)
    {
        _thisUser = user;
        ShowGlobalMenu();
    }

    private void ShowTaskMenu()
    {
        while (true && !_thisUser.IsBanned)
        {
            Console.WriteLine("Выберите действие: ");
            Console.Write("1 - Добавить задачу \n" +
                          "2 - Распечатать все задачи \n" +
                          "3 - Удалить задачу \n" +
                          "4 - Выполнить задачу \n" +
                          "5 - В главное меню \n");
            var command = Console.ReadLine();
            Console.WriteLine();
            switch (command)
            {
                case "1":
                    _thisUser.AddTask();
                    break;
                case "2":
                    _thisUser.TodoList.PrintTasks();
                    break;
                case "3":
                    _thisUser.TodoList.DeleteTask();
                    break;
                case "4":
                    _thisUser.TodoList.CompletedTask();
                    break;
                case "5":
                    ShowGlobalMenu();
                    break;
            }
        }
    }

    private void ShowGlobalMenu()
    {
        bool flag = true;
        while (flag && !_thisUser.IsBanned)
        {
            if (_thisUser.Login)
            {
                Console.WriteLine("Выберите действие: ");
                Console.Write("1 - Меню задач \n" +
                              "2 - Меню авторизации \n" +
                              "3 - Меню статистики \n" +
                              "4 - Выйти из программы \n");
                var command = Console.ReadLine();
                Console.WriteLine();
                switch (command)
                {
                    case "1":
                        ShowTaskMenu();
                        break;
                    case "2":
                        ShowMenuAuthorizations();
                        break;
                    case "3":
                        ShowStatistics();
                        break;
                    case "4":
                        flag = false;
                        _thisUser.IsBanned = true;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Выберите действие: ");
                Console.Write("1 - Авторизация \n" +
                              "2 - Регистрация \n");
                var command = Console.ReadLine();
                Console.WriteLine();
                switch (command)
                {
                    case "1":
                        _thisUser.Authorization();
                        break;
                    case "2":
                        _thisUser.RegisterAccount();
                        break;
                }
            }
        }
    }

    private void ShowStatistics()
    {
        var flag = true;

        while (flag && !_thisUser.IsBanned)
        {
            if (_thisUser.Login)
            {
                Console.WriteLine("Выберите действие: ");
                Console.Write("1 - Текущий уровень \n" +
                              "2 - Количество выполненных задач \n" +
                              "3 - В главное меню \n");
                var command = Console.ReadLine();
                Console.WriteLine();
                switch (command)
                {
                    case "1":
                        Level.CurrentLevelInformation();
                        break;
                    case "2":
                        var a = _thisUser.TodoList.CountOfCompletedTasks;
                        Console.WriteLine(a);
                        break;
                    case "3":
                        ShowGlobalMenu();
                        break;
                }
            }
        }
    } 
    
    private void ShowMenuAuthorizations()
        {
            bool flag = true;

            while (flag && !_thisUser.IsBanned)
            {
                if (_thisUser.Login)
                {
                    Console.WriteLine("Выберите действие: ");
                    Console.Write("1 - Выйти из аккаунта \n" +
                                  "2 - Сменить пароль \n" +
                                  "3 - В главное меню \n");
                    var command = Console.ReadLine();
                    Console.WriteLine();
                    switch (command)
                    {
                        case "1":
                            _thisUser.LogOut();
                            break;
                        case "2":
                            _thisUser.ChangePassword();
                            break;
                        case "3":
                            ShowGlobalMenu();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Выберите действие: ");
                    Console.Write("1 - Авторизация \n" +
                                  "2 - Регистрация \n");
                    var command = Console.ReadLine();
                    Console.WriteLine();
                    switch (command)
                    {
                        case "1":
                            _thisUser.Authorization();
                            break;
                        case "2":
                            _thisUser.RegisterAccount();
                            break;
                    }
                }
            }
        }
    }
/*Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды (их можно придумать самому). Например:
Exit – выход
SetName – Установить имя
Help – вывести список команд
SetPassword – Установить пароль
WriteName – вывести имя после ввода пароля
*/

string exit = "Exit";
string command = String.Empty;
string userName = String.Empty;
string userPassword = String.Empty;

Console.WriteLine("Готово к работе");

while (command != ToLower(exit))
{
    Console.WriteLine("Введите команду:");
    command = ToLower(Console.ReadLine());
    switch (command)
    {
        case "help":
            Console.WriteLine("Exit – выход");
            Console.WriteLine("SetName – Установить имя пользователя");
            Console.WriteLine("SetPassword – Установить пароль");
            Console.WriteLine("WriteName – Вывести имя, после ввода пароля");
            break;
        case "setname":
            if (userName == String.Empty)
            {
                Console.Write("Введите имя пользователя: ");
                userName = Console.ReadLine();
                Console.WriteLine("Имя пользователя сохранено.");
                Console.WriteLine();
                break;
            }
            else
            {
                if (userPassword == String.Empty)
                {
                    Console.WriteLine("Пароль не задан");
                    goto case "setpassword";
                }
                else
                {
                    if (CheckPassword())
                    {
                        Console.Write("Введите новое имя пользователя: ");
                        userName = Console.ReadLine();
                        Console.WriteLine("Имя пользователя сохранено.");
                        Console.WriteLine();
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Пароль не верный"); Console.WriteLine();
                        break;
                    }
                }
            }
        case "writename":
            if (userName == String.Empty)
            {
                Console.WriteLine("Имя пользователя не задано");
                goto case "setname";
            }
            else
            {
                if (userPassword == String.Empty)
                {
                    Console.WriteLine("Пароль не задан");
                    goto case "setpassword";
                }
                else
                {
                    if (CheckPassword())
                    {
                        Console.WriteLine($"Имя пользователя {userName}");
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Пароль не верный"); Console.WriteLine();
                        break;
                    }
                }
            }
        case "setpassword":
            userPassword = ChangePassword();
            Console.WriteLine();
            break;
        default:
            Console.WriteLine("Введенной команды не существует.");
            Console.WriteLine("Для просмотра списка команд наберите Help");
            Console.WriteLine();
            break;
    }
}

string ToLower(string inpText)
{
    string outpText = inpText.ToLower();
    return outpText;
}

string ChangePassword()
{
    if (userPassword == String.Empty)
    {
        Console.Write("Введите новый пароль: ");
        string password1 = ToLower(Console.ReadLine());
        Console.Write("Повторите новый пароль: ");
        string password2 = ToLower(Console.ReadLine());
        if (password1 == password2)
        {
            string password = password1;
            Console.WriteLine("Пароль успешно сохранен!");
            return password;
        }
        else
        {
            Console.WriteLine("Введённые пароли не совпадают. Пароль не сохранён");
            return String.Empty;
        }
    }
    else
    {
        Console.WriteLine("Введите старый пароль");
        string iputPassword = Console.ReadLine();
        if (iputPassword == userPassword)
        {
            Console.Write("Введите новый пароль: ");
            string password1 = ToLower(Console.ReadLine());
            Console.Write("Повторите новый пароль: ");
            string password2 = ToLower(Console.ReadLine());
            if (password1 == password2)
            {
                string password = password1;
                Console.WriteLine("Пароль успешно сохранен!");
                return password;
            }
            else
            {
                Console.WriteLine("Введённые пароли не совпадают. Пароль не сохранён");
                return userPassword;
            }
        }
        else
        {
            Console.WriteLine("Введённые пароли не совпадают. Пароль не сохранён");
            return userPassword;
        }
    }
}

bool CheckPassword()
{
    Console.Write("Введите пароль: ");
    string tempPassword = Console.ReadLine();
    bool result = tempPassword == userPassword;
    return result;
}
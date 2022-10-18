/*Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды (их можно придумать самому). Например:
+SetName – Установить имя
+Help – вывести список команд
+SetPassword – Установить пароль
+Exit – выход
WriteName – вывести имя после ввода пароля
*/

string inpExit = "Exit";
string inpHelp = "Help";
string inpSetPassword = "SetPassword";
string inputSetName = "SetName";
string inputWriteName = "WriteName";
string command = "";
string userName = "";
string userPassword = "";
string usrPasCheck1 = "";
string usrPasCheck2 = "";

Console.WriteLine("Для справки наберите Help");
while (command != inpExit) // выход из программы
{
        command = Console.ReadLine();
    if (command == inpHelp)
    {
        Console.WriteLine($"{inpExit} – выход");
        Console.WriteLine($"{inputSetName} – Установить имя");
        Console.WriteLine($"{inpSetPassword} – Установить пароль");
        Console.WriteLine($"{inputWriteName} – Вывести имя, после ввода пароля");
    }
    else if (command == inputSetName)
    {
        Console.WriteLine("Введите имя: ");
        userName = Console.ReadLine();
        Console.WriteLine("Имя сохранено");       
    }
    else if (command == inpSetPassword)
    {
        Console.WriteLine("Введите пароль");
        usrPasCheck1 = Console.ReadLine();
        Console.WriteLine("Подтвердите пароль");
        usrPasCheck2 = Console.ReadLine();
        if (usrPasCheck1 == usrPasCheck2)
        {
            Console.WriteLine("Пароль успешно сохранён.");
            userPassword = usrPasCheck1;
        }
        else
        {
            Console.WriteLine("Введённые пароли не совпадают");
        }
    }
    else if (command == inputWriteName)
    {
        Console.WriteLine("Введите пароль");
        usrPasCheck2 = Console.ReadLine();
        if (usrPasCheck2 == userPassword && usrPasCheck2 != "")
        {
           Console.WriteLine($"Имя пользователя {userName}"); 
        }
        else
        {
            Console.WriteLine("Пароль не верный!"); 
        }
    }
    else
    {
        Console.WriteLine("Команда не найдена. Для просмотра списка команд введите help");
    }

}
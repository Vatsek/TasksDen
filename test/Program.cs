/*Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды (их можно придумать самому). Например:
+SetName – Установить имя
+Help – вывести список команд
+SetPassword – Установить пароль
+Exit – выход
WriteName – вывести имя после ввода пароля
*/

string inpExit = "Exit";
string inpExitLow = inpExit.ToLower();
string inpHelp = "Help";
string inpSetPassword = "SetPassword";
string inpSetName = "SetName";
string inpWriteName = "WriteName";
string command = "";
string userName = "";
string userPassword = "";


Console.WriteLine("Готово к работе");
{
    command = Console.ReadLine();
    switch (ToLower(command))
    {
     case "help":
        Console.WriteLine($"{inpExit} – выход");
        Console.WriteLine($"{inpSetName} – Установить имя");
        Console.WriteLine($"{inpSetPassword} – Установить пароль");
        Console.WriteLine($"{inpWriteName} – Вывести имя, после ввода пароля");
        break;
     case "setname":
        Console.WriteLine("Введите имя: ");
        userName = Console.ReadLine();
        Console.WriteLine("Имя сохранено");
        break;
    
      
    }
}


string ToLower(string inpText)
{
    string outpText = inpText.ToLower();
    return outpText;
}

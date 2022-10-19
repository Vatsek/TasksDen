﻿/*Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды (их можно придумать самому). Например:
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
string usrPasCheck1 = "";
string usrPasCheck2 = "";
string userChangePassword = "";

Console.WriteLine("Готово к работе");
while (command != inpExitLow)
{
        command = Console.ReadLine();
    if (Bool(ToLower(command), ToLower(inpHelp)))
    {
        Console.WriteLine($"{inpExit} – выход");
        Console.WriteLine($"{inpSetName} – Установить имя");
        Console.WriteLine($"{inpSetPassword} – Установить пароль");
        Console.WriteLine($"{inpWriteName} – Вывести имя, после ввода пароля");
    }
    else if (Bool(ToLower(command), ToLower(inpSetName)))
    {
        Console.WriteLine("Введите имя: ");
        userName = Console.ReadLine();
        Console.WriteLine("Имя сохранено");       
    }
    else if (Bool(ToLower(command), ToLower(inpSetPassword)))
    {
        if (userPassword != "")
        {
            Console.WriteLine("Для смены пароля введите старый пароль");
            userChangePassword = Console.ReadLine();
            if (Bool (userPassword, userChangePassword))
            {
                Console.WriteLine("Введите новый пароль");
                usrPasCheck1 = Console.ReadLine();
                Console.WriteLine("Подтвердите пароль");
                usrPasCheck2 = Console.ReadLine();
                if (Bool(usrPasCheck1, usrPasCheck2))
                {
                    userPassword = usrPasCheck1;
                }
            }    
            else
            {
                Console.WriteLine("Введённые пароли не совпадают. Пароль не сохранён");
                
            }
        }   
        else 
        {
            Console.WriteLine("Введите пароль");
            usrPasCheck1 = Console.ReadLine();
            Console.WriteLine("Подтвердите пароль");
            usrPasCheck2 = Console.ReadLine();
        }
        if (Bool(usrPasCheck1, usrPasCheck2))
        {
            Console.WriteLine("Пароль успешно сохранён.");
            userPassword = usrPasCheck1;
        }
        else
        {
            Console.WriteLine("Введённые пароли не совпадают. Пароль не сохранён");
        }
    }
    else if (Bool(ToLower(command), ToLower(inpWriteName)))
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
    else if (Bool(ToLower(command), ToLower(inpExitLow)))
    {
        return;
    }
    
    else
    {
        Console.WriteLine("Команда не найдена. Для просмотра списка команд введите help");
    }

}
bool Bool(string arg1, string arg2)
{
    bool result = arg1 == arg2;
    return result;
}

string ToLower(string inpText)
{
    string outpText = inpText.ToLower();
    return outpText;
}
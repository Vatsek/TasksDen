/*В переменной string есть секретное сообщение, во второй есть пароль. 
Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.*/

string password = "qwerty";

Console.Write("Введите пароль ");

int count = 1;

string secretMessage = "Угадал";

string inputPassword = (Console.ReadLine());

if (password == inputPassword)
{
    Console.WriteLine(secretMessage);
}

else
{
    while (count < 3)
    {
        Console.WriteLine("Пароль не верный");
        count = count +1;
        inputPassword = (Console.ReadLine());
    }
Console.Write("Доступ заблокирован");
}





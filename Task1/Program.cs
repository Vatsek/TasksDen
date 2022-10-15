/*В переменной string есть секретное сообщение, во второй есть пароль. 
Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.*/

string password = "qwerty";
int count = 0;
Console.Write("Введите пароль ");
string secretMessage = "Угадал";
string inputPassword = "0";

while (count < 3)
{
    inputPassword = Console.ReadLine();
    if (inputPassword == password)
    {
        break;
    }
    else
    {
        Console.WriteLine("Пароль не верный");
        count++;
    }
}
if (inputPassword == password)
{
    Console.WriteLine(secretMessage);
}
else
{
    Console.WriteLine("Доступ заблокирован");
}
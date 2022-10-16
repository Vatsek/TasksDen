/*3. Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. 
Если пользователь дает неправильный ответ, то программа сообщает, 
больше загаданное число или меньше. На отгадывание дается 3 попытки. */

int number = new Random().Next(1, 10);
int count = 0;
int attempt = 3;
int inputNumber = -1;

//Console.WriteLine("загаданное число " + number);

Console.WriteLine("Игра началась)");
Console.WriteLine("Введи число:");

while (count < attempt)
{
    inputNumber = Convert.ToInt32(Console.ReadLine());
    if (inputNumber == number)
    {
        break;
    }
    else if (inputNumber < number)
    {
        Console.WriteLine("Загаданное число больше");
        count++;
    }
    else if (inputNumber > number)
    {
        Console.WriteLine("Загаданное число меньше");
        count++;
    }

}
if (inputNumber == number)
{
    Console.WriteLine("Правильно, ты выиграл!!!");
}
else
{
    Console.WriteLine("Ты проиграл((");
}
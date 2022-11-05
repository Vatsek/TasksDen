/*Конвертер валют. У пользователя есть баланс в каждой из представленных валют. 
С помощью команд он может попросить сконвертировать одну валюту в другую. 
Курс конвертации просто описать в программе. Программа заканчивает свою работу в тот момент,
 когда решит пользователь.*/
//                     rur    usd   eur
double[] ballance = { 10000, 1000, 1000 };
string[] currencySign = { "руб", "usd", "euro" };
double[] ratesToRur = { 1, 61.33, 60.46 };
const int rurIndex = 0;
const int usdIndex = 1;
const int eurIndex = 2;
bool isWork = true;
while (isWork)
{
    Console.WriteLine("Доступные счета: rur, usd, eur");
    Console.WriteLine("Введите счёт с которго хотите списать деньги: ");
    string accountFrom = Console.ReadLine().ToLower();
    if (CheckExit(accountFrom))
    {
        isWork = false;
        continue;
    }
    int indexFrom = BallanceIndex(accountFrom);
    if (indexFrom < 0)
    {
        Console.WriteLine("Такого счета не существует");
        continue;
    }
    Console.WriteLine("Введите сумму для конвертации");
    string sumInp = Console.ReadLine();
    if (CheckExit(sumInp))
    {
        isWork = false;
        continue;
    }
    double sum = Convert.ToDouble(sumInp);
    if (sum <= 0)
    {
        Console.WriteLine("Можно сконвертировать сумму, только больше нуля");
    }
    if (ballance[indexFrom] < sum)
    {
        Console.WriteLine("На счете недостаточно средств");
        continue;
    }
    Console.WriteLine("Введите счёт на который хотите зачислить деньги: ");
    string accountTo = Console.ReadLine().ToLower();
    if (CheckExit(accountFrom))
    {
        isWork = false;
        continue;
    }
    if (accountFrom == accountTo)
    {
        Console.WriteLine("Введенные счета совпадают. Невозможно сконвертировать");
        Console.WriteLine();
        continue;
    }
    int indexTo = BallanceIndex(accountTo);
    if (indexTo < 0)
    {
        Console.WriteLine("Такого счета не существует");
        Console.WriteLine();
        continue;
    }
    double conversionRate = GetConversationRate(indexFrom, indexTo);
    double conversationSum = sum * conversionRate;
    ballance[indexFrom] -= sum;
    ballance[indexTo] += conversationSum;
    Console.WriteLine();
    Console.WriteLine(
        $"Остаток на счете {accountFrom} составляет {Math.Round(ballance[indexFrom], 2)} {currencySign[indexFrom]}");
    Console.WriteLine($"Сконвертированная сумма {Math.Round(conversationSum, 2)} {currencySign[indexTo]}");
    Console.WriteLine($"Баланс счета {accountTo} составляет {Math.Round(ballance[indexTo], 2)} {currencySign[indexTo]}");
    Console.WriteLine();
}
bool CheckExit(string command)
{
    return command == "exit";
}
double GetConversationRate(int indexFrom, int indexTo)
{
    return ratesToRur[indexFrom] / ratesToRur[indexTo];
}
int BallanceIndex(string accountFromTo)
{
    switch (accountFromTo)
    {
        case "rur":
            return rurIndex;
        case "usd":
            return usdIndex;
        case "eur":
            return eurIndex;
        default:
            return -1;
    }
}
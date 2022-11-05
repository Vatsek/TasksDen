/*Конвертер валют. У пользователя есть баланс в каждой из представленных валют. 
С помощью команд он может попросить сконвертировать одну валюту в другую. 
Курс конвертации просто описать в программе. Программа заканчивает свою работу в тот момент,
 когда решит пользователь.*/

//                     rur    usd   eur
double[] ballance = { 10000, 1000, 1000 };
string[] currencySign = { "руб", "usd", "euro" };
string exit = "Exit";
string command = String.Empty;
double sum = 0;
double convSum = 0;
double conversionRate = 0;
string accountFrom = String.Empty;
string accountTo = String.Empty;
int account = 0;
double rurusd = 0.0163;
double rureur = 1.0165;
double usdrur = 61.33;
double usdeur = 1.0044;
double eurrur = 60.46;
double eurusd = 0.9956;


while (command != ToLower(exit))
{
    Console.WriteLine("Доступные счета: rur, usd, eur");

    Console.WriteLine("Введите счёт с которго хотите списать деньги: ");

    accountFrom = ToLower(Console.ReadLine());

    if (CheckExit(accountFrom))
    {
        command = accountFrom;
        continue;
    }
    else
    {
        if (AccCheck(accountFrom))
        {
        }
        else
        {
            Console.WriteLine("Такого счета не существует");
            Console.WriteLine();
            continue;
        }
    }
    int indFrom = BallanceIndex(accountFrom);

    Console.WriteLine("Введите сумму для конвертации");

    string sumInp = Console.ReadLine();

    if (CheckExit(sumInp))
    {
        command = sumInp;
        continue;
    }
    else
        sum = Convert.ToDouble(sumInp);

    if (sum > 0)
    { }
    else
    {
        Console.WriteLine("Можно сконвертировать сумму, только больше нуля");
    }
    if (ballance[indFrom] < sum)
    {
        Console.WriteLine("На счете недостаточно средств");
        continue;
    }
    Console.WriteLine("Введите счёт на который хотите зачислить деньги: ");

    accountTo = ToLower(Console.ReadLine());

    if (accountFrom == accountTo)
    {
        Console.WriteLine("Введенные счета совпадают. Невозможно сконвертировать");
        Console.WriteLine();
        continue;
    }
    if (CheckExit(accountTo))
    {
        command = accountTo;
        continue;
    }
    else
    {
        if (AccCheck(accountTo))
        {
        }
        else
        {
            Console.WriteLine("Такого счета не существует");
            Console.WriteLine();
            continue;
        }
    }
    int indTo = BallanceIndex(accountTo);

    string accFromTo = accountFrom + accountTo;

    conversionRate = ConvRate(accFromTo);

    convSum = sum * conversionRate;

    ballance[indFrom] = ballance[indFrom] - sum;

    ballance[indTo] = ballance[indTo] + convSum;

    Console.WriteLine();

    Console.WriteLine($"Остаток на счете {accountFrom} составляет {Math.Round(ballance[indFrom], 2)} {currencySign[indFrom]}");

    Console.WriteLine($"Сконвертированная сумма {Math.Round(convSum, 2)} {currencySign[indTo]}");

    Console.WriteLine($"Баланс счета {accountTo} составляет {Math.Round(ballance[indTo], 2)} {currencySign[indTo]}");
    
    Console.WriteLine();

}



bool CheckExit(string command)
{
    if (command == "exit")
        return true;
    else
        return false;

}

double ConvRate(string command)
{
    switch (command)
    {
        case "rurusd":
            return conversionRate = rurusd;
            break;
        case "rureur":
            return conversionRate = rureur;
            break;
        case "usdrur":
            return conversionRate = usdrur;
            break;
        case "usdeur":
            return conversionRate = usdeur;
            break;
        case "eurrur":
            return conversionRate = eurrur;
            break;
        case "eurusd":
            return conversionRate = eurusd;
            break;
    }
    return conversionRate;
}

string ToLower(string inpText)
{
    string outText = inpText.ToLower();
    return outText;
}

int BallanceIndex(string accountFromTo)
{
    switch (accountFromTo)
    {
        case "rur":
            int account = 0;
            return account;
            break;
        case "usd":
            account = 1;
            return account;
            break;
        case "eur":
            account = 2;
            return account;
            break;
    }
    return account;
}

bool AccCheck(string account)
{
    if (account == "rur" || account == "usd" || account == "eur")
    {
        return account == "rur" || account == "usd" || account == "eur";
    }
    else
    {
        return false;
    }

}

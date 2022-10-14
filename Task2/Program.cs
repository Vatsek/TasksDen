//Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается

int count = 0;

string Quit = "ex";

while (Quit != "exit")
{
    count ++;
    Console.WriteLine(count);
    Quit = Console.ReadLine();
}




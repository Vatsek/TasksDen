//7. Написать функцию Shuffle, которая перемешивает элементы массива в случайном порядке.

string[] text = { "Этот", "текст","нужно","перемешать" };

Random rand = new Random();

WriteArray(text);

text = Shuffle(text);

WriteArray(text);

string[] Shuffle(string[] inpText)
{
    for (int i = 0; i < inpText.Length; i++)
    {
        int randIndex = rand.Next(0, inpText.Length-1);
        string temp = inpText[i];
        inpText[i] = inpText[randIndex];
        inpText[randIndex] = temp;
    }
    return inpText;
}

void WriteArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
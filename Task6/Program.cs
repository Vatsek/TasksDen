/* Написать 2 функции для работы с массивом: AddToArray И RemoveFromArray – первая добавляет 
к числовому массиву значение, тем самым увеличивая массив, а вторая удаляет элемент под нужным 
индексом и уменьшает массив на 1. */

int[] numbers = new int[10];

FillArray(numbers);

Console.WriteLine("Изначальный массив: ");
PrintArray(numbers);


Console.Write("Введите значение, которое хотите добавить в массив: ");
int num = Convert.ToInt32(Console.ReadLine());

numbers = AddToArray(numbers, num);

Console.WriteLine("Введите индекс элемента, который хотите удалить: ");
int indexToDel = Convert.ToInt32(Console.ReadLine());

numbers = RemoveFromArray(numbers, indexToDel);


int[] AddToArray(int[] arrayToAdd, int value)
{
    int size = arrayToAdd.Length;
    int[] addArray = new int[++size];
    for (int i = 0; i < addArray.Length - 1; i++)
    {
        addArray[i] = numbers[i];
    }
    addArray[addArray.Length - 1] = value;

    Console.WriteLine("Новый увеличенный массив: ");
    PrintArray(addArray);

    return addArray;
}


int[] RemoveFromArray(int[] arrayFromRem, int indx)
{
    int size = arrayFromRem.Length;

    int[] reduceArray = new int[--size];

    if (indx >= arrayFromRem.Length)
    {
        Console.WriteLine("Такого индекса в массиве нет. Массив остался неизменным");
        PrintArray(numbers);

        return arrayFromRem;
    }
    else
    {
        for (int i = 0; i < indx; i++)
        {
            reduceArray[i] = arrayFromRem[i];
        }
        for (int i = indx; i < arrayFromRem.Length - 1; i++)
        {
            reduceArray[i] = arrayFromRem[i + 1];
        }
        Console.WriteLine("Новый уменьшенный массив: ");
        PrintArray(reduceArray);
        
        return reduceArray;
    }
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
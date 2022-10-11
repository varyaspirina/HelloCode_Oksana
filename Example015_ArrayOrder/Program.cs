// Упорядочить массив от меньшего к большему

void FillArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(1, 90);
    }
}

// Метод, который выводит массив на экран
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();    
}

// Метод, который упорядочивает массив по возрастанию элементов
void ascendingOrdering(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[maxPosition]) maxPosition = j;

        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

// Метод, который упорядочивает массив по убыванию элементнов

void descendingOrdering(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}


// Программа
Console.Clear();
int[] arr = new int[10];
FillArray(arr);
Console.WriteLine("Изначальный массив:");
PrintArray(arr);
Console.WriteLine("Сортировка по возрастанию:");
ascendingOrdering(arr);
PrintArray(arr);
Console.WriteLine("Сортировка по убыванию:");
descendingOrdering(arr);
PrintArray(arr);

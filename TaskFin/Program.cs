
string[] arr1 = { "Hello", "2", "world", ":-)" };
string[] arr2 = { "1234", "1567", "-2", "AYG" };
string[] arr3 = { "Lesson", "Field", "Tree" };

int maxLength = 3;

string[] GetShortWordsArray(string[] array)
{
    string[] result = new string[array.Length];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            result[count] = array[i];
            count++;
        }

    }
    if (count == 0)
    {
        result = new string[0];
    }
    string[] shortArr = new string[count];
    shortArr = result;
    return shortArr;
}

void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Такие элементы отсутствуют");
    }
    else
    {

        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length - 1)
                Console.Write($"{array[i]} ");
            else Console.WriteLine($"{array[i]} ");
        }

    }
}

void PrintTask(string[] array)
{
    Console.WriteLine("Заданный массив:");
    PrintArray(array);
    string[] shortArray = GetShortWordsArray(array);
    Console.WriteLine($"Массив с длинной элементов менее или равной {maxLength} символам:");
    PrintArray(shortArray);
    Console.WriteLine();
}

PrintTask(arr1);
PrintTask(arr2);
PrintTask(arr3);

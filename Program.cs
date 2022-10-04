string[] arr = { "hi", "hello", "geekbrains", "programmer", "^_^", "git" };

void PrintArray(string[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void Choose3OrLess(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count += 1;
    }

    string[] newarr = new string[count];

    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarr[j] = arr[i];
            j++;
        }
    }
    PrintArray(newarr);
}

PrintArray(arr);
Console.Write("Новый массив: ");
Choose3OrLess(arr);


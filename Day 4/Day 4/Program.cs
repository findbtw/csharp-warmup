Arrays();
Console.WriteLine("\n--- Нажми любую клавишу для следующей задачи ---");
Console.ReadKey();
ListT();
Console.WriteLine("\n--- Нажми любую клавишу для следующей задачи ---");
Console.ReadKey();
Twodarray();

static void Arrays()
{
    int[] array = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int num = 0;
    double average = 0;
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        num += array[i];
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine("Sum: " + num);
    average = (double)num / array.Length;
    Console.WriteLine("Average: " + average);
    Console.WriteLine("Max: " + max);
    Console.WriteLine("Min: " + min);
}

static void ListT()
{
    List<int> array = new List<int> { 1, 2, 3, 4, 5, 10, 12, 23, 44, 55 };
    array.Add(13);
    array.Add(22);
    array.Add(67);
    array.Remove(10);
    int sum = 0;
    int max = array[0];
    int min = array[0];
    double avarage;
    for (int i = 0; i < array.Count; i++)
    {
        sum += array[i];
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    avarage = (double)sum / array.Count;
    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Max: {max}");
    Console.WriteLine($"Min: {min}");
    Console.WriteLine($"Average: {avarage}");
}

static void Twodarray()
{
    int[,] array = new int[3, 3];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

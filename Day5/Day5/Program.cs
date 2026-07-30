int[] array = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Метрики массива через методы (Sum, Average, Min, Max)
Console.WriteLine("--- Array metrics ---");
Console.WriteLine("Sum: " + MathHelper.Sum(array));
Console.WriteLine("Average: " + MathHelper.Average(array));
Console.WriteLine("Max: " + MathHelper.Max(array));
Console.WriteLine("Min: " + MathHelper.Min(array));

// Перегрузка Max — версия для двух чисел
Console.WriteLine("\n--- Overloading ---");
Console.WriteLine("Max(10, 20): " + MathHelper.Max(10, 20));

// IsInRange — проверка на нескольких значениях, включая границы
Console.WriteLine("\n--- IsInRange ---");
Console.WriteLine("IsInRange(5, 1, 10): " + MathHelper.IsInRange(5, 1, 10));   // true, внутри диапазона
Console.WriteLine("IsInRange(1, 1, 10): " + MathHelper.IsInRange(1, 1, 10));   // true, равно нижней границе
Console.WriteLine("IsInRange(10, 1, 10): " + MathHelper.IsInRange(10, 1, 10)); // true, равно верхней границе
Console.WriteLine("IsInRange(15, 1, 10): " + MathHelper.IsInRange(15, 1, 10)); // false, за границей

class MathHelper
{
    public static int Sum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    public static double Average(int[] array)
    {
        int sum = Sum(array);
        return (double)sum / array.Length;
    }

    public static int Max(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    public static int Min(int[] array)
    {
        int min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    // Перегрузка: тот же Max, но для двух чисел вместо массива
    public static int Max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    public static bool IsInRange(int value, int min, int max)
    {
        return value >= min && value <= max;
    }
}

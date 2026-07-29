int[] array  = new int[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
int num = 0;
double average = 0;
int max = array[0];
int min = array[0];
for  (int i = 0; i < array.Length; i++)
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


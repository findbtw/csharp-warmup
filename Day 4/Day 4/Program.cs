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
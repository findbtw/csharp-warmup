using System.Diagnostics;

// ===== Задача 1: Простой async-метод =====
Console.WriteLine("--- Задача 1: Greet ---");
Console.WriteLine("Starting the greeting process...");
await GreetAsync("Alice");
Console.WriteLine("Greeting process completed.");

async Task GreetAsync(string name)
{
    Console.WriteLine($"Hello, {name}!");
    await Task.Delay(1000);
    Console.WriteLine($"Goodbye, {name}!");
}

// ===== Задача 2: Task<T> с результатом =====
Console.WriteLine("\n--- Задача 2: CalculateSquareAsync ---");
Console.Write("Enter a number to calculate its square: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Calculating the square of {number}...");
int squareResult = await CalculateSquareAsync(number);
Console.WriteLine($"The square of {number} is: {squareResult}");
Console.WriteLine("Calculation complete.");

async Task<int> CalculateSquareAsync(int n)
{
    await Task.Delay(1000);
    return n * n;
}

// ===== Задача 3: Несколько await подряд + замер времени =====
Console.WriteLine("\n--- Задача 3: Breakfast (sequential) ---");
Console.WriteLine("Starting breakfast preparation...");
Console.WriteLine("Preparing coffee, toast, and eggs...");
var stopwatch = Stopwatch.StartNew();
await BrewCoffeeAsync();
await ToastBreadAsync();
await FryEggsAsync();
stopwatch.Stop();
Console.WriteLine("Breakfast is ready!");
Console.WriteLine($"Total time elapsed: {stopwatch.ElapsedMilliseconds} ms ({stopwatch.Elapsed.TotalSeconds:F2} seconds)");

async Task BrewCoffeeAsync()
{
    Console.WriteLine("Starting to brew coffee...");
    await Task.Delay(3000);
    Console.WriteLine("Coffee is ready!");
}

async Task ToastBreadAsync()
{
    Console.WriteLine("Starting to toast bread...");
    await Task.Delay(2000);
    Console.WriteLine("Bread is ready!");
}

async Task FryEggsAsync()
{
    Console.WriteLine("Starting to fry eggs...");
    await Task.Delay(1000);
    Console.WriteLine("Eggs are ready!");
}
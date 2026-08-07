using System.Diagnostics;

// ===== Задача 1: Task.WhenAll (без результата) =====
Console.WriteLine("--- Задача 1: Параллельный завтрак ---");
Console.WriteLine("Starting breakfast preparation...");
Console.WriteLine("Preparing coffee, toast, and eggs...");
var stopwatch1 = Stopwatch.StartNew();
Task coffeeTask = BrewCoffeeAsync();
Task toastTask = ToastBreadAsync();
Task eggsTask = FryEggsAsync();
await Task.WhenAll(coffeeTask, toastTask, eggsTask);
stopwatch1.Stop();
Console.WriteLine("Breakfast is ready!");
Console.WriteLine($"Total time elapsed: {stopwatch1.ElapsedMilliseconds} ms ({stopwatch1.Elapsed.TotalSeconds:F2} seconds)");

// ===== Задача 2: Task.WhenAll с результатами =====
Console.WriteLine("\n--- Задача 2: Параллельные вычисления с результатом ---");
Task<int> numberOne = CalculateSquareAsync(7);
Task<int> numberTwo = CalculateSquareAsync(5);
Task<int> numberThree = CalculateSquareAsync(3);
int[] squareResults = await Task.WhenAll(numberOne, numberTwo, numberThree);
Console.WriteLine($"The squares are: {string.Join(", ", squareResults)}");
Console.WriteLine("Calculation complete.");

// ===== Задача 3: Сравнение — последовательно vs параллельно =====
Console.WriteLine("\n--- Задача 3: Сравнение sequential vs parallel ---");
Console.WriteLine("Sequential run:");
var stopwatchSeq = Stopwatch.StartNew();
await BrewCoffeeAsync();
await ToastBreadAsync();
await FryEggsAsync();
stopwatchSeq.Stop();
Console.WriteLine($"Sequential total: {stopwatchSeq.Elapsed.TotalSeconds:F2} seconds");

Console.WriteLine("\nParallel run:");
var stopwatchPar = Stopwatch.StartNew();
Task coffeeTask2 = BrewCoffeeAsync();
Task toastTask2 = ToastBreadAsync();
Task eggsTask2 = FryEggsAsync();
await Task.WhenAll(coffeeTask2, toastTask2, eggsTask2);
stopwatchPar.Stop();
Console.WriteLine($"Parallel total: {stopwatchPar.Elapsed.TotalSeconds:F2} seconds");

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
    await Task.Delay(5000);
    Console.WriteLine("Eggs are ready!");
}

async Task<int> CalculateSquareAsync(int n)
{
    await Task.Delay(1000);
    return n * n;
}
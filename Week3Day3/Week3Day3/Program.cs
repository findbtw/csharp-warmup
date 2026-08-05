using System.Linq;

// ===== Задача 1: Sum, Max, Min, Average =====
Console.WriteLine("--- Задача 1: Агрегатные функции ---");
int[] prices = { 250, 89, 430, 120, 75, 310, 199 };
var maxPrice = prices.Max();
var sumPrice = prices.Sum();
var minPrice = prices.Min();
var averagePrice = prices.Average();
Console.WriteLine($"Max Price: {maxPrice}");
Console.WriteLine($"Sum Price: {sumPrice}");
Console.WriteLine($"Min Price: {minPrice}");
Console.WriteLine($"Average Price: {averagePrice}");

// ===== Задача 2: Sum с условием =====
Console.WriteLine("\n--- Задача 2: Sum цен больше 150 ---");
var sumOverThreshold = prices.Where(price => price > 150).Sum();
Console.WriteLine(sumOverThreshold);

// ===== Задача 3: GroupBy по чётности =====
Console.WriteLine("\n--- Задача 3: Группировка чисел по чётности ---");
int[] numbers = { 12, 7, 23, 44, 15, 8, 31, 56, 19, 40 };
var groupedNumbers = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");
foreach (var group in groupedNumbers)
{
    Console.WriteLine($"{group.Key}: {string.Join(", ", group)}");
}

// ===== Задача 4: GroupBy по первой букве =====
Console.WriteLine("\n--- Задача 4: Группировка фруктов по первой букве ---");
string[] fruits = { "apple", "banana", "avocado", "cherry", "blueberry", "apricot" };
var groupedFruits = fruits.GroupBy(fruit => fruit[0]);
foreach (var group in groupedFruits)
{
    Console.WriteLine($"Fruits starting with '{group.Key}': {string.Join(", ", group)}");
}

// ===== Бонус: GroupBy + Select + Where + OrderBy — отчёт по выручке =====
Console.WriteLine("\n--- Бонус: Выручка по категориям (> 500) ---");
var sales = new[]
{
    new { Category = "Electronics", Item = "Phone", Price = 800, Quantity = 2 },
    new { Category = "Books",       Item = "C# Guide", Price = 40,  Quantity = 5 },
    new { Category = "Electronics", Item = "Laptop", Price = 1200, Quantity = 1 },
    new { Category = "Clothing",    Item = "Jacket", Price = 150, Quantity = 3 },
    new { Category = "Books",       Item = "LINQ Book", Price = 30, Quantity = 10 },
    new { Category = "Clothing",    Item = "Socks",  Price = 10,  Quantity = 2 },
    new { Category = "Electronics", Item = "Mouse",  Price = 25,  Quantity = 4 }
};

var revenueReport = sales
    .GroupBy(s => s.Category)
    .Select(g => new { Category = g.Key, TotalRevenue = g.Sum(x => x.Price * x.Quantity) })
    .Where(g => g.TotalRevenue > 500)
    .OrderByDescending(g => g.TotalRevenue);

foreach (var item in revenueReport)
{
    Console.WriteLine($"  {item.Category}: {item.TotalRevenue:F2}");
}
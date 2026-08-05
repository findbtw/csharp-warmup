using System.Linq;
using System.Collections.Generic;

// ===== Задача 1: Создание и базовый доступ =====
Console.WriteLine("--- Задача 1: Базовый доступ по ключу ---");
Dictionary<string, int> products = new Dictionary<string, int>()
{
    { "Apple", 25 },
    { "Banana", 32 },
    { "Orange", 43 },
    { "Grapes", 54 },
    { "Mango", 35 }
};
int applePrice = products["Apple"];
Console.WriteLine($"Apple price: {applePrice}");

// ===== Задача 2: TryGetValue =====
Console.WriteLine("\n--- Задача 2: TryGetValue ---");
Console.WriteLine("Enter the product name to get its price:");
string productName = Console.ReadLine();

if (products.TryGetValue(productName, out int price))
{
    Console.WriteLine($"The price of {productName} is {price}.");
}
else
{
    Console.WriteLine($"Product '{productName}' not found.");
}

// ===== Задача 3: Добавление, обновление, удаление =====
Console.WriteLine("\n--- Задача 3: CRUD-операции ---");
Console.WriteLine("Original Product List:");
foreach (var product in products)
{
    Console.WriteLine($"{product.Key}: {product.Value}");
}

products["Peach"] = 28;
products["Banana"] = 30;
products.Remove("Grapes");

Console.WriteLine("\nUpdated Product List:");
foreach (var product in products)
{
    Console.WriteLine($"{product.Key}: {product.Value}");
}

// ===== Задача 4: Dictionary + LINQ =====
Console.WriteLine("\n--- Задача 4: Товары дороже 30 ---");
var moreThanThirty = products.Where(p => p.Value > 30);
Console.WriteLine(string.Join(", ", moreThanThirty.Select(p => p.Key)));
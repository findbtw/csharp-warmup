using System.Collections.Generic;
using System.Linq;

// ===== Задача 1: Уникальные значения через конструктор =====
Console.WriteLine("--- Задача 1: Уникальные города ---");
string[] cities = { "Oslo", "Bergen", "Oslo", "Trondheim", "Bergen", "Stavanger" };
HashSet<string> uniqueCities = new HashSet<string>(cities);
foreach (var c in uniqueCities)
{
    Console.WriteLine(c);
}

// ===== Задача 2: Add и проверка дубликатов =====
Console.WriteLine("\n--- Задача 2: Add с проверкой дубликатов ---");
HashSet<int> numbers = new HashSet<int>();
foreach (var number in new int[] { 1, 2, 3, 2, 4, 3, 5 })
{
    bool added = numbers.Add(number);
    Console.WriteLine($"Number: {number}, Added: {added}");
}

// ===== Задача 3: Операции над множествами =====
Console.WriteLine("\n--- Задача 3: Множества студентов ---");
HashSet<string> mathStudents = new HashSet<string> { "Anna", "Boris", "Chris", "Dan" };
HashSet<string> physicsStudents = new HashSet<string> { "Chris", "Dan", "Elena", "Fred" };

HashSet<string> both = new HashSet<string>(mathStudents);
both.IntersectWith(physicsStudents);
Console.WriteLine("Both subjects: {0}", string.Join(", ", both));

HashSet<string> atLeastOne = new HashSet<string>(mathStudents);
atLeastOne.UnionWith(physicsStudents);
Console.WriteLine("At least one subject: {0}", string.Join(", ", atLeastOne));

HashSet<string> onlyMath = new HashSet<string>(mathStudents);
onlyMath.ExceptWith(physicsStudents);
Console.WriteLine("Math only: {0}", string.Join(", ", onlyMath));
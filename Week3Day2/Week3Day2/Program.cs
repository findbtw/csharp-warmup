using System.Linq;

// ===== Задача 1: OrderBy / OrderByDescending =====
Console.WriteLine("--- Задача 1: Сортировка ---");
int[] scores = { 67, 45, 89, 23, 91, 56, 78 };
var sortedAscending = scores.OrderBy(score => score);
var sortedDescending = scores.OrderByDescending(score => score);
Console.WriteLine(string.Join(", ", sortedAscending));
Console.WriteLine(string.Join(", ", sortedDescending));

// ===== Задача 2: First / FirstOrDefault =====
Console.WriteLine("\n--- Задача 2: First / FirstOrDefault ---");
var first = scores.First(score => score > 80);
Console.WriteLine(first);
var firstOrDefault = scores.FirstOrDefault(score => score > 200);
Console.WriteLine(firstOrDefault);

// ===== Задача 3: Any / All =====
Console.WriteLine("\n--- Задача 3: Any / All ---");
bool less = scores.Any(score => score < 30);
Console.WriteLine($"Are there any scores less than 30? {less}");
bool more = scores.All(score => score > 20);
Console.WriteLine($"Are all scores greater than 20? {more}");

// ===== Задача 4: Where + OrderBy в цепочке =====
Console.WriteLine("\n--- Задача 4: Фильтрация + сортировка имён ---");
string[] students = { "Dmytro", "Anna", "Yevhen", "Olena", "Bo" };
var sortedStudents = students.Where(s => s.Length > 3).OrderBy(s => s);
Console.WriteLine(string.Join(", ", sortedStudents));
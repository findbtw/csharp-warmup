using System.Linq;

// ===== Задача 1: Where — фильтрация чисел =====
Console.WriteLine("--- Задача 1: Числа больше 10 ---");
int[] numbers = { 3, 8, 15, 22, 7, 40, 11, 6, 19, 25 };
var moreThanTen = numbers.Where(n => n > 10);
foreach (var number in moreThanTen)
{
    Console.WriteLine(number);
}

// ===== Задача 2: Select — заглавные буквы в именах =====
Console.WriteLine("\n--- Задача 2: Capitalize через Select ---");
string[] names = { "anna", "boris", "chris" };
var upperNames = names.Select(name => char.ToUpper(name[0]) + name.Substring(1).ToLower());
foreach (var name in upperNames)
{
    Console.WriteLine(name);
}

// ===== Задача 3: Where + Select в цепочке =====
Console.WriteLine("\n--- Задача 3: Чётные числа в квадрате ---");
int[] moreNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var evenSquares = moreNumbers.Where(n => n % 2 == 0).Select(n => n * n);
Console.WriteLine(string.Join(", ", evenSquares));

// ===== Задача 4: Фильтр слов через Where (сравнение с Днём 3) =====
Console.WriteLine("\n--- Задача 4: Слова длиннее 5 символов ---");
string[] words = { "кот", "программирование", "дом", "университет", "код", "студент" };
var longWords = words.Where(word => word.Length > 5);
foreach (var word in longWords)
{
    Console.WriteLine(word);
}
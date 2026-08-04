// ===== Задача 1: Nullable Reference Types =====
Console.WriteLine("--- Задача 1: Nullable Reference Types ---");
string?[] users = { "Anna", null, "Boris", null, "Chris" };
Console.WriteLine("Enter user ID to search from 0, to " + (users.Length - 1));
int id = int.Parse(Console.ReadLine());
string? foundUser = FindUserById(id, users);
Console.WriteLine(foundUser ?? "Пользователь не найден");
Console.WriteLine("Длина имени: " + (foundUser?.Length ?? -1));

// ===== Задача 2: Pattern Matching =====
Console.WriteLine("\n--- Задача 2: Pattern Matching ---");
Console.Write("Введите объект для описания: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int parsedInt))
{
    DescribeObject(parsedInt);
}
else if (double.TryParse(input, out double parsedDouble))
{
    DescribeObject(parsedDouble);
}
else if (string.IsNullOrEmpty(input))
{
    DescribeObject(null);
}
else
{
    DescribeObject(input);
}

// ===== Задача 3: Records =====
Console.WriteLine("\n--- Задача 3: Records ---");
Person person1 = new Person("Alice", 30);
Person person2 = new Person("Alice", 30);
Console.WriteLine("person1 == person2: " + (person1 == person2));
Console.WriteLine(person2);

// ===== Методы =====

string? FindUserById(int id, string?[] users)
{
    return users[id];
}

void DescribeObject(object obj)
{
    if (obj is int i)
    {
        Console.WriteLine($"Integer: {i}");
    }
    else if (obj is string s)
    {
        Console.WriteLine($"String: {s}");
    }
    else if (obj is null)
    {
        Console.WriteLine("Null object");
    }
    else if (obj is double d)
    {
        Console.WriteLine($"Double: {d}");
    }
    else
    {
        Console.WriteLine($"Other type: {obj.GetType().Name}");
    }
}

// ===== Record — обязательно в самом конце файла =====
record Person(string Name, int Age);
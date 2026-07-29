MultiplicationTable();
Console.WriteLine("\n--- Нажми любую клавишу для следующей задачи ---");
Console.ReadKey();
GuessTheNumberFixed();
Console.WriteLine("\n--- Нажми любую клавишу для следующей задачи ---");
Console.ReadKey();
GuessTheNumberRandom();
Console.WriteLine("\n--- Нажми любую клавишу для следующей задачи ---");
Console.ReadKey();
WordFilter();
Console.WriteLine("\n--- Нажми любую клавишу для следующей задачи ---");
Console.ReadKey();
FizzBuzz();

static void MultiplicationTable()
{
    for (int i = 1; i <= 10; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            int result = i * j;
            Console.WriteLine($"{i} * {j} = {result}");
        }
        Console.WriteLine();
    }
}

static void GuessTheNumberFixed()
{
    Console.WriteLine("Угадайте число");
    int secretNumber = 7;
    bool isGuessed = false;

    while (true)
    {
        Console.Write("Введите ваше число: ");
        int guess = Convert.ToInt32(Console.ReadLine());
        if (guess == secretNumber)
        {
            Console.WriteLine("Поздравляю! Вы угадали число.");
            isGuessed = true;
            break;
        }
        else if (guess < secretNumber)
        {
            Console.WriteLine("Загаданное число больше.");
        }
        else
        {
            Console.WriteLine("Загаданное число меньше.");
        }
    }
}

static void GuessTheNumberRandom()
{
    Console.WriteLine("Угадайте число от 1 до 100");
    Random rand = new Random();
    int number = rand.Next(1, 101);
    bool isGuessed = false;

    while (true)
    {
        Console.Write("Введите ваше число: ");
        int guess = Convert.ToInt32(Console.ReadLine());
        if (guess == number)
        {
            Console.WriteLine("Поздравляю! Вы угадали число!");
            isGuessed = true;
            break;
        }
        else if (guess < number)
        {
            Console.WriteLine("Загаданное число больше.");
        }
        else
        {
            Console.WriteLine("Загаданное число меньше.");
        }
    }
}

static void WordFilter()
{
    string[] words = { "кот", "программирование", "дом", "университет", "код", "символы", "семь", "Norway" };
    Console.WriteLine("Слова с длиной больше 5 символов:");
    foreach (string word in words)
    {
        if (word.Length > 5)
        {
            Console.WriteLine($"{word} ");
        }
    }
}

static void FizzBuzz()
{
    for (int i = 1; i <= 100; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}
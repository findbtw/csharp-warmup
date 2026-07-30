using System.Text;

// ===== Задача 1: Разворот строки =====
Console.WriteLine("--- Задача 1: Разворот строки ---");
string text = "Programming";
StringBuilder sb = new StringBuilder();
for (int i = 0; i < text.Length; i++)
{
    sb.Append(text[text.Length - 1 - i]);
}
string reversedText = sb.ToString();
Console.WriteLine($"Исходная строка: {text}");
Console.WriteLine($"Развёрнутая строка: {reversedText}");

// ===== Задача 2: Проверка палиндрома =====
Console.WriteLine("\n--- Задача 2: Проверка палиндрома ---");
string phrase = "А роза упала на лапу Азора";
string cleanedPhrase = phrase.Replace(" ", "").ToLower();
bool isPalindromeResult = IsPalindrome(cleanedPhrase);
Console.WriteLine($"Исходная строка: {phrase}");
Console.WriteLine($"Is palindrome: {isPalindromeResult}");

// ===== Задача 3: Подсчёт гласных =====
Console.WriteLine("\n--- Задача 3: Подсчёт гласных ---");
string vowelSentence = "Я сейчас буду делать новую программу и мне интересно сколько тут гласных";
int vowelsCount = CountVowels(vowelSentence);
Console.WriteLine($"В строке: \"{vowelSentence}\"");
Console.WriteLine($"Количество гласных: {vowelsCount}");

// ===== Задача 4: Split/Join =====
Console.WriteLine("\n--- Задача 4: Split/Join ---");
string sentence = "C# is fun to learn";
string[] words = sentence.Split(' ');
Console.WriteLine($"Количество слов: {words.Length}");
string joinedSentence = string.Join("-", words);
Console.WriteLine($"Результат: {joinedSentence}");

// ===== Методы =====

static string Reverse(string s)
{
    StringBuilder sb = new StringBuilder();
    for (int i = s.Length - 1; i >= 0; i--)
    {
        sb.Append(s[i]);
    }
    return sb.ToString();
}

static bool IsPalindrome(string s)
{
    return s == Reverse(s);
}

static int CountVowels(string s)
{
    string vowels = "аеёиоуыэюя";
    int count = 0;

    foreach (char c in s)
    {
        char lowerC = char.ToLower(c);
        if (vowels.Contains(lowerC))
        {
            count++;
        }
    }

    return count;
}
Console.Write("Ваш бал за экзамен: ");

int grade = Convert.ToInt32(Console.ReadLine());

string result = grade switch
{
    >= 90 => "A",
    >= 75 => "B",
    >= 60 => "C",
    >= 40 => "D",
    _ => "F"
};
Console.WriteLine($"Ваша оценка: {result}");
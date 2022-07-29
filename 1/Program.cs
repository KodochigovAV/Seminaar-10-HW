// Задача 4: Есть монотонная последовательность, 
// каждое число встречается ровно то количество раз, 
// какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... 
// Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию:
// N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5" (N = равно количество выводимых элементов)

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

void Digits(int number, int start = 1)
{
    if (start > number)
    {
        return;
    }

    for (int j = 0; j < start; j++)
    {
        System.Console.Write($"{start}; ");
    }
    Digits(number, start + 1);
}

Digits(Prompt("Enter -> "));
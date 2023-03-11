// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");

int res = DelSecond(number);
Console.WriteLine($"Первая и третья цифра трехзначного числа {res}");

int DelSecond(int num)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    int res = firstDigit * 10 + thirdDigit;
    return res;
}
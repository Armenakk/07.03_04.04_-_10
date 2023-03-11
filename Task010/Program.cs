// Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите любое целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int Secondnum = number / 10;
    int Secondnumber = Secondnum % 10;
    Console.WriteLine($"Последняя цифра {Secondnumber}");
}
else
{
    Console.WriteLine($"такая цифра не подходит");
}

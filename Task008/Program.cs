// Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите любое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
bool not = true;
while (count <= number)
{
    if (count % 2 != 1)
    {
        Console.Write(count + ", ");
        not = false;
    }
    count++;
}
if (not)
{
    Console.WriteLine("К сожалению четных чисел нет!");
}
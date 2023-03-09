// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите целое число: ");

int a = Convert.ToInt32 (Console.ReadLine());

if (a == 1)
{
    Console.WriteLine($"По номеру {a} - Понедельник");
}

if (a == 2)
{
    Console.WriteLine($"По номеру {a} - Вторник");
}

if (a == 3)
{
    Console.WriteLine($"По номеру {a} - Среда");
}

if (a == 4)
{
    Console.WriteLine($"По номеру {a} - Четверг");
}

if (a == 5)
{
    Console.WriteLine($"По номеру {a} - Пятница");
}

if (a == 6)
{
    Console.WriteLine($"По номеру {a} - Суббота");
}

if (a == 7)
{
    Console.WriteLine($"По номеру {a} - Воскресенье");
}

if (a > 7)
{
    Console.WriteLine($"По номеру {a} - Нет такой недели");
}
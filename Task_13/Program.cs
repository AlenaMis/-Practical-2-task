// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.WriteLine("Ведите число от 10 до 99999 : ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 10 && n < 100) 
    Console.WriteLine("Третьей цифры нет.");

else if (n >= 100 && n < 1000)
{
    int n1 = (n % 10);
    Console.WriteLine($"Третье число: {n1}"); 
}

else if (n >= 1000 && n < 10000)
{ 
    int n1 = (n / 10) % 10;
    Console.WriteLine($"Третье число: {n1}"); 
}

else if (n >= 10000 && n < 100000)
{
    int n1 = (n / 100) % 10;
    Console.WriteLine($"Третье число: {n1}"); 
}

    
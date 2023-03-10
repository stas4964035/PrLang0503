// //задача 11 hard. Напишите программу, которая принимает от пользователя целое число любой разрядности и удаляет вторую цифру этого числа.

int RazrCounter(int n)
{
    int counter = 0;
    while(n > 0)
    {
        counter++;
        n /= 10;
    }
    return counter;
}
int FirstDigit(int n){
    int res = 0;
    while(n > 0)
    {
        res = n;
        n /= 10;
    }
    return res;
}
int LastDigits(int n, int start = 2){
    return n % Convert.ToInt32(Math.Pow(10, RazrCounter(n) - 2));
}

int numb = new Random().Next(100, Convert.ToInt32(Math.Pow(10, new Random().Next(2, 9))));

Console.WriteLine($"{numb}:  {FirstDigit(numb)}{LastDigits(numb)}");


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if(n > 999 || n < 100)
// {
//     Console.WriteLine("Число не трехзначное");
// }
// else
// {
//     Console.WriteLine($"Вторая цифра: { (n/10)%10 }");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int razr = RazrCounter(n);
// if(razr < 3)
// {
//     Console.WriteLine("Разрядность менее 3!");
// }
// else
// {
//     n /= Convert.ToInt32(Math.Pow(10, razr - 3));
//     n %= 10;
//     Console.WriteLine($"Третья цифра: {n}");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите номер дня: ");
// int d = Convert.ToInt32(Console.ReadLine());
// if(d > 5 && d < 8)
// {
//     Console.WriteLine("Да");
// }
// else if(d <= 5)
// {
//     Console.WriteLine("Нет");
// }
// else Console.WriteLine("Введенное значение не является днем недели.");

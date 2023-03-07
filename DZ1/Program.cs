// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > b) Console.WriteLine("Большее: " + a + "; Меньшее: " + b);
// else Console.WriteLine("Большее: " + b + "; Меньшее: " + a);



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (b > a) max = b;
// if (c > b) max = c;
// Console.WriteLine("Максимальное из 3 чисел: " + max);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if(a % 2 == 0) Console.WriteLine("Число " + a + " четное.");
// else Console.WriteLine("Число " + a + " нечетное.");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// for(int i = 1; i < a; i++)
// {
//     if(i % 2 == 0) Console.Write(i + " ");
// }

// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, которая принимает на вход целое число любой разрядности 
// и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int razr = 1, tmp = a;
while(tmp > 10)
{
    tmp = tmp / 10;
    razr++;
}
if(razr > 1)
{
    tmp = razr - 2;
    while(tmp != 0)
    {
        a = a / 10;
        tmp--;
    }
    Console.WriteLine(a%10);
}
else Console.WriteLine("Разрядность слишком мала");
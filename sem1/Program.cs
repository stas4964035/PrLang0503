// Console.WriteLine("Enter integer:");
// int num = Convert.ToInt32( Console.ReadLine());
// int square = num * num;
// Console.WriteLine("Квадрат: " + square);

// if(num < 0)
// {
//     Console.WriteLine("Число отрицательное.");
// }
// else
// {
//     Console.WriteLine("Число не отрицательное.");
// }

Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет

Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int numKV = num2 * num2;
// if (numKV == num1) { Console.WriteLine("является"); }
// else Console.WriteLine("не является");

// Console.WriteLine("Введите число : ");
// string dayNum = Console.ReadLine();

// if(dayNum=="1") Console.WriteLine ("Понедельник");
// else if(dayNum=="2") Console.WriteLine ("Вторник");
// else if(dayNum=="3") Console.WriteLine ("Среда");
// else if(dayNum=="4") Console.WriteLine ("Четверг");
// else if(dayNum=="5") Console.WriteLine ("Пятница");
// else if(dayNum=="6") Console.WriteLine ("Суббота");
// else if(dayNum=="7") Console.WriteLine ("Воскресенье");
// else Console.WriteLine ("Введите другое число");


// Console.WriteLine("Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());

// int start = number*(-1);

// while(start<=number) {
//     Console.Write (start+", ");
//     start++;
// }
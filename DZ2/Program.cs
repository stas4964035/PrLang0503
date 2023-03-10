//задача 11 hard. Напишите программу, которая принимает от пользователя целое число любой разрядности и удаляет вторую цифру этого числа.

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


int Max(int a, int b, int c)
{
    int max = a;
    if (b > a) max = b;
    if (c > b) max = c;
    return max;
}
int a1 = 10;
int b1 = 100;
int c1 = 1000;
int a2 = 10000;
int b2 = 100000;
int c2 = 1000000;
int a3 = 10000000;
int b3 = 100000000;
int c3 = 1000000000;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

Console.WriteLine(Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)));
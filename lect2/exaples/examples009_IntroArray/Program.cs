int Max(int a, int b, int c)
{
    int max = a;
    if (b > a) max = b;
    if (c > b) max = c;
    return max;
}
int[] array = {11,22,43,42,35,66,17,78,19};



Console.WriteLine(Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8])));
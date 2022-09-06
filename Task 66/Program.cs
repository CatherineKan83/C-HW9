int sum(int m, int n)
{
    int result =0;
    if(m>n) result =((m+n)*(m-n+1))/2;
    else result = ((m+n)*(n-m+1))/2;
    return result;
}

Console.Write("Введите число M: ");
int M= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N= Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M = {M}; N= {N} --> {sum(M,N)}");
int sum(int m, int n)
{
    if(m>n) return (((m+n)*(m-n+1))/2);
    else return (((m+n)*(n-m+1))/2);
}

Console.Write("Введите число M: ");
int M= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N= Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M = {M}; N= {N} --> {sum(M,N)}");
int Akkerman(int a, int b)
{
    int c=0;
    if(a==0)
    {
        c= b+1;
    }
    else if(a!=0&&b==0)
    {
        c = Akkerman(a-1,1);
    }
    else c = Akkerman(a-1,Akkerman(a,b-1));
    return c;
}

Console.Write("Введите первое число: ");
int M=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int N=Convert.ToInt32(Console.ReadLine());
Console.Write($" M = {M}, N = {N} --> A(M,N) = {Akkerman(M,N)}");

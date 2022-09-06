string Numbers(int c, int e)
{
    if(c>=e) return $" {c} " + Numbers(c-1,e);
    else return String.Empty;
}
Console.Write("Введите число: ");
int N= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("N = " + $"{N}" + "-->" + Numbers(N,1));

string Numbers(int c, int e)
{
    string temp=String.Empty;
    if(c>=e) temp= $" {c} " + Numbers(c-1,e);
    return temp;

}
Console.Write("Введите число: ");
int N= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("N = " + $"{N}" + "-->" + Numbers(N,1));

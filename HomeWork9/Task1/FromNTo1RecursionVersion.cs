Console.WriteLine("Insert number N:");
int n = Convert.ToInt32(Console.ReadLine());
void PrintFromNTo1(int n)
{
    if(n > 0)
    {
        Console.Write($"{n} ");
        PrintFromNTo1(n - 1);
    }
}
PrintFromNTo1(n);
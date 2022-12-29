Console.WriteLine("Insert number A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert number B:");
int b = Convert.ToInt32(Console.ReadLine());
int AckermannFunction(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return AckermannFunction(n - 1, 1);
    else
      return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
}
Console.Write($"Ackerman function for numbers ({a},{b}) is: {AckermannFunction(a,b)}");
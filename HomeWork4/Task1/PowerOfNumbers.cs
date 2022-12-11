Console.WriteLine("Insert number A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert number B:");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
while(b != 0)
{
    result = result * a;
    b--;
}
Console.WriteLine($"The result is - {result}");

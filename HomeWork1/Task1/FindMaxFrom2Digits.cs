Console.WriteLine("Input first number 'a':");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number 'b':");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
	int max = a;
	Console.WriteLine("max = {0}",max);
}
else
{
	int max = b;
	Console.WriteLine("max = {0}",max);
}	
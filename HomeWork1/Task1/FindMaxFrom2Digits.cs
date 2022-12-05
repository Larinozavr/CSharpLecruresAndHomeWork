Console.WriteLine("Input first number 'a':");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number 'b':");
int b = Convert.ToInt32(Console.ReadLine());
int max;
if(a > b)
{
	max = a;
	Console.WriteLine("max = {0}",max);
}
else
{
	max = b;
	Console.WriteLine("max = {0}",max);
}	
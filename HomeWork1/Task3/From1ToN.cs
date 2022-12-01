Console.WriteLine("Input number 'n':");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i < n+1)
{
if( i%2 ==0)
{
    Console.WriteLine(i);
}
i++;
}
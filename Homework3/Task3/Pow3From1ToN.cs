Console.WriteLine("Please, input number: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrayOfCubes = new int[n];
for (int i = 1;  i < n + 1; i++ )
{
    arrayOfCubes[i-1] = Convert.ToInt32(Math.Pow(i,3));
}
void ArrayPrinter(int[] a)
{
    Console.Write("This is your array of cubes: ");
    foreach (int i in arrayOfCubes)
    {
        Console.Write($"[{i}] ");
    }
}    
ArrayPrinter(arrayOfCubes);
Console.WriteLine("Input first number 'a':");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number 'b':");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number 'c':");
int c = Convert.ToInt32(Console.ReadLine());
int[] z = new int[3] { a, b, c };
Array.Sort(z);
int x = z[2];
Console.WriteLine("Max number = {0}",x);




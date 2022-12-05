Console.WriteLine("Please, insert three-digits number: ");
int n = Convert.ToInt32(Console.ReadLine());
n = n / 10;
n = n % 10;
Console.WriteLine($"The second digit is = {n}");
Console.WriteLine("Insert your number:");
string n = Console.ReadLine();
int nLen = n.Length;
if(nLen < 3)
    {
    Console.WriteLine("Your number is not three-digits!");
    }
else
    {
    Console.WriteLine($"The third digit in your number: {n[2]}");
    }
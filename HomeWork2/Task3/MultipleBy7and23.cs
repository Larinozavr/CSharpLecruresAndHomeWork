Console.WriteLine("Insert your number:");
int n = Convert.ToInt32(Console.ReadLine());
if(n % 7 == 0 & n % 23 == 0)
    {
    Console.WriteLine("Your number is a multiple of both 7 and 23, good job!");
    }
else
    {
    Console.WriteLine("Your number is NOT a multiple of both 7 and 23, sorry.");
    }

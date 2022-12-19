Console.WriteLine("How many numbers will you want to input?");
int countOfNumbers = Convert.ToInt32(Console.ReadLine());
int countOfPositiveNumbers = 0;
for(int i = countOfNumbers; i != 0; i--)
{
    Console.WriteLine("Please, input number:");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number > 0)
    {
        countOfPositiveNumbers++;
    }
    Console.WriteLine($"Okey, {i-1} left.");
}
Console.WriteLine($"Very well, you entered {countOfPositiveNumbers} positive numbers");
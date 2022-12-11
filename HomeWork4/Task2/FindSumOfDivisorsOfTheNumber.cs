Console.WriteLine("Input your number: ");
int n = Convert.ToInt32(Console.ReadLine());
int sumOfDivisors = 0;
int numberForCutOut = n;
while(numberForCutOut != 0)
{
    if(numberForCutOut % 10 != 0 && n % (numberForCutOut % 10) == 0)
    {
        sumOfDivisors += (numberForCutOut % 10);  
    }
    numberForCutOut = numberForCutOut / 10;  
}
Console.WriteLine($"Sum of divisors of the number = {sumOfDivisors}");

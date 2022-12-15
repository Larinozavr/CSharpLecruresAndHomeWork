int randomArrayLength = new Random().Next(10, 101);
Random randomNumberBetweenHundridAndThousand = new Random();
int[] arrayOfRandomNumbers = new int[randomArrayLength];
for(int i = 0; i < randomArrayLength; i++)
{
	arrayOfRandomNumbers[i] = randomNumberBetweenHundridAndThousand.Next(100, 1000);
}
int countOfEven = 0;
foreach(int i in arrayOfRandomNumbers)
{
    if(i % 2 == 0)
    {
    	countOfEven++;
   	}
}
Console.Write("[ ");
for(int i = 0; i < randomArrayLength; i++)
{
   	Console.Write($"{arrayOfRandomNumbers[i]} ");
}
Console.Write("]");
Console.WriteLine(string.Empty);
Console.WriteLine($"Count of even: {countOfEven}.");


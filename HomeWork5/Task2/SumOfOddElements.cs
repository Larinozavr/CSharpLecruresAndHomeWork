


int randomArrayLength = new Random().Next(10,101);
int[] arrayOfRandomNumbers = new int[randomArrayLength];
Random randomInt = new Random();
for(int i = 0;i < randomArrayLength; i++)
{
	arrayOfRandomNumbers[i] = randomInt.Next(int.MinValue, int.MaxValue);
}
long sumOfElements = 0;
for(int i = 0; i < randomArrayLength; i++)
{
	if(i % 2 == 0)
	{
		sumOfElements += arrayOfRandomNumbers[i];
	}
}
Console.Write("[ ");
for(int i = 0; i < randomArrayLength; i++)
{
   	Console.Write($"{arrayOfRandomNumbers[i]} ");
}
Console.Write("]");
Console.WriteLine("\n");
Console.WriteLine($"Sum of elements on odd positions is: {sumOfElements}");
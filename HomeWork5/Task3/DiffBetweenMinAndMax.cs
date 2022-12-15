int randomArrayLength = new Random().Next(2, 101);
double[] arrayOfRandomDouble = new double[randomArrayLength];
Random randomDouble = new Random();
for(int i = 0;i < randomArrayLength; i++)
{
	arrayOfRandomDouble[i] = randomDouble.Next(int.MinValue, int.MaxValue) + randomDouble.NextDouble();
}
double tempo = 0.0;
for(int i = randomArrayLength-1; i > 0; i--)
{
	if(arrayOfRandomDouble[i] < arrayOfRandomDouble[i-1])
	{
		tempo = arrayOfRandomDouble[i];
		arrayOfRandomDouble[i] = arrayOfRandomDouble[i-1];
		arrayOfRandomDouble[i-1] = tempo;
	}
}
for(int i = 0; i < randomArrayLength-1; i++)
{
	if(arrayOfRandomDouble[i] > arrayOfRandomDouble[i+1])
	{
		tempo = arrayOfRandomDouble[i];
		arrayOfRandomDouble[i] = arrayOfRandomDouble[i+1];
		arrayOfRandomDouble[i+1] = tempo;
	}
}
Console.Write("[ ");
for(int i = 0; i < randomArrayLength; i++)
{
   	Console.Write($"{arrayOfRandomDouble[i]} ");
}
Console.Write("]");
Console.WriteLine("\n");
Console.WriteLine($"The difference is: {arrayOfRandomDouble[randomArrayLength-1] - arrayOfRandomDouble[0]}");
Random randomFiller = new Random();
int[,] randomArray = new int[randomFiller.Next(10,101),randomFiller.Next(10,101)];
double[] arrayWithAverage = new double[randomArray.GetLength(1)];
for(int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i,j] = randomFiller.Next(100,1000);
        }
    }
for(int i = 0; i < randomArray.GetLength(1); i++)
{
    int CountOfPalindrome = 0;
    for(int j = 0; j < randomArray.GetLength(0); j++)
    {
        if(randomArray[j,i] % 10 == randomArray[j,i] / 100)
        {
            arrayWithAverage[i] += randomArray[j,i];
            CountOfPalindrome += 1;
        }
    }
    if(CountOfPalindrome != 0)
    {
        arrayWithAverage[i] /= CountOfPalindrome;
    }
}
Console.WriteLine("Random array with three-digits numbers:");
Console.Write($"[ ");
for(int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            Console.Write($"{randomArray[i,j]} ");
        }
        Console.WriteLine(String.Empty);
    }
Console.Write($"]");
Console.WriteLine(String.Empty);
Console.WriteLine("Array of Average Palindroms in Colomns:");
Console.Write($"[ ");
for(int i = 0; i < arrayWithAverage.Length; i++)
{
    Console.Write($"{Math.Round(arrayWithAverage[i],2)} ");
}
Console.Write($"]");

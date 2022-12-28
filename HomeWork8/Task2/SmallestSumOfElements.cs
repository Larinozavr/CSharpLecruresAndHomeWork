Random randomFiller = new Random();
int[,] randomArray = new int[ randomFiller.Next(3,6), randomFiller.Next(3,6)];//Ограничил 5 для удобства чтения.
int[] arrayForCountSum = new int[randomArray.GetLength(0)];
int indexOfSmallestElement = 0;
for(int i = 0; i < randomArray.GetLength(0); i++)
{
    for(int j = 0; j < randomArray.GetLength(1); j++)
    {
        randomArray[i, j] = randomFiller.Next(101);//Ограничил 100 для удобства чтения.
    }    
}
for(int i = 0; i < randomArray.GetLength(0); i++)
{
    for(int j = 0; j < randomArray.GetLength(1); j++)
    {
        arrayForCountSum[i] += randomArray[i, j];
    }    
}
for(int i = 0; i < arrayForCountSum.Length -1; i++)
{
    if(arrayForCountSum[i] > arrayForCountSum[i+1])
    {
        indexOfSmallestElement = i+1;
    }
}
Console.WriteLine("Array with random numbers: ");
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
Console.WriteLine($"String with smallest sum of elements: {indexOfSmallestElement + 1}");


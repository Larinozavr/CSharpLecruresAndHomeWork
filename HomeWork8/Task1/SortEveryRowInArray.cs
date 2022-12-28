Random randomFiller = new Random();
int[,] randomArray = new int[randomFiller.Next(16), randomFiller.Next(16)];//Ограничил 15 для удобства чтения.
int temp = 0;
int countOfloops = 0;
for(int i = 0; i < randomArray.GetLength(0); i++)
{
    for(int j = 0; j < randomArray.GetLength(1); j++)
    {
        randomArray[i, j] = randomFiller.Next(101);//Ограничил 100 для удобства чтения.
    }    
}
for(int i = 0; i < randomArray.GetLength(0); i++)
{
    while(countOfloops < randomArray.GetLength(1))
    {
        for(int j = 0; j < randomArray.GetLength(1) -1; j++)
        {
            if(randomArray[i, j] > randomArray[i, j+1])
            {
                temp = randomArray[i, j+1];
                randomArray[i, j+1] = randomArray[i, j];
                randomArray[i, j] = temp;
            }
        }
        countOfloops++;
    }
    countOfloops = 0;
}
Console.WriteLine("Sorted array of random numbers: ");
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
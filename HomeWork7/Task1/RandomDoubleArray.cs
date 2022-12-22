Random randomFiller = new Random();
double[,] randomArray = new double[randomFiller.Next(101),randomFiller.Next(101)];
for(int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i,j] = randomFiller.Next() + randomFiller.NextDouble();
        }
    }
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
Console.WriteLine($"Random double array [{randomArray.GetLength(0)},{randomArray.GetLength(1)}] created.");

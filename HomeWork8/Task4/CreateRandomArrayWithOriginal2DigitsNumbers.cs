Random randNumber = new Random();
int[,] arrayWithOriginalNumbers = new int[randNumber.Next(2,10),randNumber.Next(2,10)];
bool IsThisNumberAlreadyInArray(int n, int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == n)
            {
                return true;
            }
        }
    }
    return false;
}
for(int i = 0; i < arrayWithOriginalNumbers.GetLength(0); i++)
    {
        for(int j = 0; j < arrayWithOriginalNumbers.GetLength(1); j++)
        {
            while(true)
            {
                int challenger = randNumber.Next(10,100);
                if(IsThisNumberAlreadyInArray(challenger,arrayWithOriginalNumbers) == false)
                {
                    arrayWithOriginalNumbers[i, j] = challenger;
                    break;
                }
            }
        }
    }
Console.WriteLine($"Rows in array: {arrayWithOriginalNumbers.GetLength(0)}");
Console.WriteLine($"Columns in array: {arrayWithOriginalNumbers.GetLength(1)}");
for(int i = 0; i < arrayWithOriginalNumbers.GetLength(0); i++)
{
    for(int j = 0; j < arrayWithOriginalNumbers.GetLength(1); j++)
    {
        Console.Write($"{arrayWithOriginalNumbers[i, j]} ");
    }
    Console.WriteLine(string.Empty);
}

Random randomFiller = new Random();
int[,] randomArray = new int[randomFiller.Next(101),randomFiller.Next(101)];
for(int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i,j] = randomFiller.Next();
        }
    }
Console.WriteLine("Please input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input count of colomns: ");
int colomns = Convert.ToInt32(Console.ReadLine());
try
{
    Console.WriteLine($"Element [{rows},{colomns}] is: {randomArray[rows,colomns]}");
}
catch(Exception)
{
    Console.WriteLine("This element is not exist!");
}

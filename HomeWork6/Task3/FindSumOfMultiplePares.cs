

int randomLenthOfArray = new Random().Next(11);
int[] arrayOfRandomNumbers = new int[randomLenthOfArray];
Random filler = new Random();
int total = 0;
for(int i = randomLenthOfArray-1; i > -1; i--)
{
    arrayOfRandomNumbers[i] = filler.Next(10);
}
for(int i = 0, j = randomLenthOfArray -1; i < randomLenthOfArray / 2; i++, j--)
{
    total += arrayOfRandomNumbers[i] * arrayOfRandomNumbers[j];
}
Console.Write($"Array: [ ");
for(int i = 0; i < randomLenthOfArray; i++)
{
   Console.Write($" {arrayOfRandomNumbers[i]} ");
}
Console.Write($" ]");
Console.WriteLine(string.Empty);
Console.WriteLine($"Sum of products of pairs is: {total}");
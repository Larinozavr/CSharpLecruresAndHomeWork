Random arrayExtentions = new Random();
int[,] arrayForFilling = new int[arrayExtentions.Next(2,11),arrayExtentions.Next(2,11)];
arrayForFilling[0,0] = 1;
int i = 0;
int j = 0;
int n = 1;
while(true)
{
    if(j+1 < arrayForFilling.GetLength(1) && arrayForFilling[i, j+1] == 0)
    {
        arrayForFilling[i, j+1] = n;
        n++;
        j++;
    }
    else if(i+1 < arrayForFilling.GetLength(0) && arrayForFilling[i+1, j] == 0)
    {
        arrayForFilling[i+1, j] = n;
        n++;
        i++;
    }
    else if(j-1 >= 0 && arrayForFilling[i, j-1] == 0)
    {
        arrayForFilling[i, j-1] = n;
        n++;
        j--;
    }
    else if(arrayForFilling[i-1, j] == 0)
    {
        while(arrayForFilling[i-1, j] == 0)
        {
            arrayForFilling[i-1, j] = n;
            n++;
            i--;
        }
    }
    else
    {
        break;
    }
}
arrayForFilling[0,0] = 0;
void PrintArray(int[,] array)
{
Console.WriteLine($"Rows in array: {array.GetLength(0)}");
Console.WriteLine($"Columns in array: {array.GetLength(1)}");
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        if(array[i, j] >= 10)
        {
            Console.Write($"{array[i, j]} ");
        }
        else
        {
            Console.Write($"0{array[i, j]} ");
        }
    }
    Console.WriteLine(string.Empty);
}
}
PrintArray(arrayForFilling);

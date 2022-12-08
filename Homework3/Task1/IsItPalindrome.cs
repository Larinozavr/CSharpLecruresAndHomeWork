Console.WriteLine("Please, input number: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n < 0)
{
    n = n * -1;
}
if (n < 10)
{
    Console.WriteLine("I have no idea why d'you input single number, and don't know is it palindrome, or not!!");
}
else
{
    int counter = n;
    int nLen = 0;
    while (counter > 0)
    {
        counter = counter / 10;
        nLen++;
    }
    int countOfCompares = nLen / 2;
    int frontCounter = Convert.ToInt32(Math.Pow(10, nLen - 1));
    int backCounter = 10;
        if ((n / frontCounter) == (n % backCounter))
        {
            frontCounter = frontCounter / 10;
            backCounter = backCounter * 10;
            countOfCompares--;
            while (true)
            {
                if ((n / frontCounter) % 10 == (n % backCounter) / (backCounter / 10))
                {
                    frontCounter = frontCounter / 10;
                    backCounter = backCounter * 10;
                    countOfCompares--;
                    if(countOfCompares > 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("It is a palindrome!");
                        break;    
                    }
                }
                else
                {
                    Console.WriteLine("This is not a palindrome!ф");
                    break;            
                }
            }
            
        }
        else
        {
            Console.WriteLine("This is not a palindrome!");
        }
}
Console.WriteLine("Please, input number: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int counter = n;
int nLen = 0;
while(counter > 0)
    {
        counter = counter / 10;
        nLen++;    
    }
int countOfCompares = nLen / 2;
Console.WriteLine(nLen);
Console.WriteLine(countOfCompares);
int frontCounter = Convert.ToInt32(Math.Pow(10,nLen-1));
int backCounter = 10;
while( countOfCompares != 0 )
    {
        if((n / frontCounter) % backCounter == (n % backCounter ) / (backCounter / 10))
        {
            frontCounter = frontCounter / 10;
            backCounter = backCounter * 10;
            countOfCompares--;
            Console.WriteLine(frontCounter);
            Console.WriteLine(backCounter);
            Console.WriteLine(countOfCompares);
            if(countOfCompares == 1)
            {
                Console.WriteLine("It is a palindrome!");
                break;
            }

        }
        else
        {
            Console.WriteLine("This is not a palindrome!");
            break;
        }
    }





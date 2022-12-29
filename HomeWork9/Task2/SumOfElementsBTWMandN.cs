Console.WriteLine("Insert number M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert number N:");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
void SumOfElementsBetweenTwoNumbers(int m, int n)
    {   
        if(m <= n)
        {
        sum += m + n;
        SumOfElementsBetweenTwoNumbers(m+1,n-1);
        }
        else
        {   
            sum -= (m + n)/2;
            Console.WriteLine(sum);
        }
    }
SumOfElementsBetweenTwoNumbers(m, n);
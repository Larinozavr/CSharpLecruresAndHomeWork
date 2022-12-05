Console.WriteLine("Введите число 'a':");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 'b':");
int b = Convert.ToInt32(Console.ReadLine());
if(a < b)
{    
    if(b % a == 0)
        Console.WriteLine($"Второе число кратно первому");
    else
    {
         Console.WriteLine($"Число не кратно, остаток - {b%a}");  
    }
}
else
{
    if(a % b == 0)
        Console.WriteLine($"Второе число кратно первому");
    else
    {
         Console.WriteLine($"Число не кратно, остаток - {a%b}");  
    }
}
// Задача 3: **(Дополнительное, не обязательно)
// Назовём число «интересным» если его произведение цифр делится на их сумму. Напишите программу,
// которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000. (каждый эл-т массива – сгенерирован случайно)
// [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]
int[] arrayOfInterestingNumbers = new int[10];
int GeneratorOfIntestingNumber()
{
    while(true)
    {
        int sumDigitsOfN = 0;
        int multipleDigitsOfN = 1;
        int n = new Random().Next(10, 1001);
        int challenger = n;
        if( n % 10 == 0 | (n /10) % 10 == 0)
        {
            continue;
        }   
        while(n > 0)
        {
            sumDigitsOfN += n % 10;
            multipleDigitsOfN = multipleDigitsOfN * (n % 10);
            n = n / 10;
        }
        if(multipleDigitsOfN % sumDigitsOfN == 0)
        {    
            return challenger;
        }   
    }
}
Console.Write("Your array of interesting numbers is:[");
for(int i = 0; i < arrayOfInterestingNumbers.Length; i++)
{
    arrayOfInterestingNumbers[i] = GeneratorOfIntestingNumber();
    Console.Write($" {arrayOfInterestingNumbers[i]} ");
}
Console.Write("]");

// // Напишите программу, которая принимает на вход число 
// //и выдаёт количество цифр в числе. 456 -> 3; 78 -> 2; 89126 -> 5

// Console.WriteLine("введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while (A > 1)
// {
//     A = A/10;
//     count++;
// }
// Console.WriteLine(count);

// Console.WriteLine("введите число: ");
// double Cycle (double A)
// {   int sum = 0; //count
//     while (A > 1)
//     {
//        A = A/10; 
//        Console.WriteLine(A/10);
//        sum++;
//     }
//     return sum;
// }

// double A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Cycle(A));

int Cycle(int a)                                                  //15
{
    int sum = 0;                                                  //0           1         3
    for(int i = 1; i<=a; i++)                                     //1 < 15 ;    2 <  15   3 <  15
    {
        sum = sum + i;                                            //0 + 1 = 1 ; 1+2 = 3   3+3 = 6
        Console.WriteLine(sum);
    }
    return sum;
}
Console.Write("введите число A: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Результат работы программы = {Cycle(number)}");


// // Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. 456 -> 3; 78 -> 2; 89126 -> 5

// Console.WriteLine("введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while (A > 1)
// {
//     A = A/10;
//     count++;
// }
// Console.WriteLine(count);

Console.WriteLine("введите число: ");
double Cycle (double A)
{   int sum = 0; //count
    while (A > 1)
    {
       A = A/10; 
       Console.WriteLine(A/10);
       sum++;
    }
    return sum;
}

double A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Cycle(A));


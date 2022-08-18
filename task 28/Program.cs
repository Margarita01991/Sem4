// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. 4 -> 24; 5 -> 120
Console.Clear();
Console.WriteLine("введите число N: ");
int number = Convert.ToInt32(Console.ReadLine()); 

int product  = 1;      

for(int i = 1; i <= number; i++)             
{
        product = i * product;      // 5 = 1 x 2 x 3 x 4 x 5                    
}
Console.Write($"Результат работы программы = {product}");


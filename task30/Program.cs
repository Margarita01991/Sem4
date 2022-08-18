// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]
Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Random rnd = new Random();      
for(int i = 0; i <= array.Length; i++)             
{
        array[N] = Convert.ToInt32(rnd.Next(0,2));     
        Console.WriteLine(N);                   
}
Console.Write(array);

﻿// принимает на вход число A и выдает сумму чисел от 1 до A
Console.Clear();
Console.Write("Введите число A: ");
int number = Convert.ToInt32(Console.Read()); //принимаем это число Convert.ToInt32(numberText[0].ToString())
int sum  = 0;                                 //так как нужно будет записывать сумму принимаем в еще одну переменную
//  i=1, т.к. от 1 до А
for(int i = 1; i<=number; i++)                // используем цикл
{
        sum = sum + i;
}
Console.Write($"Результат = {sum}");
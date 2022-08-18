// принимает на вход число A и выдает сумму чисел от 1 до A
Console.Clear();
int Cycle(int a)                              // используем функцию
{
    int sum  = 0;                             //так как нужно будет записывать сумму принимаем в еще одну переменную
    for(int i = 1; i<=a; i++)                 // используем цикл
    {
        sum = sum + i;
    }
    return sum;
}

Console.Write("Введите число A: ");
int number = Convert.ToInt32(Console.ReadLine()); //принимаем это число Convert.ToInt32(numberText[0].ToString())
int sum = Cycle(number);
Console.Write($"Результат = {sum}");          //($"Результат = {Cycle(number)}");

//то же с рассчетом
// int Cycle(int a)                                                  //15
// {
//     int sum = 0;                                                  //0           1         3
//     for(int i = 1; i<=a; i++)                                     //1 < 15 ;    2 <  15   3 <  15
//     {
//         sum = sum + i;                                            //0 + 1 = 1 ; 1+2 = 3   3+3 = 6
//     }
//     return sum;
// }
// Console.Write("введите число A: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Результат работы программы = {Cycle(number)}");

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
int number = Convert.ToInt32(Console.Read()); //принимаем это число Convert.ToInt32(numberText[0].ToString())
int sum = Cycle(number);
Console.Write($"Результат = {sum}");          //($"Результат = {Cycle(number)}");

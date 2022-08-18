// принимает на вход число A и выдает сумму чисел от 1 до A
Console.Clear();
Console.Write("Введите число A: ");
int number = Convert.ToInt32(Console.ReadLine()); //принимаем это число Convert.ToInt32(numberText[0].ToString())
Console.Write(number);
int sum  = 0;                                 //так как нужно будет записывать сумму принимаем в еще одну переменную
for(int i = 1; i <= number; i++)               //  i=1, т.к. от 1 до А, пока i меньше вводимого числа, прибавляем шаг 1 к i
{
        sum = sum + i;                       // возвращаем сумму         
}
Console.Write($"Результат работы программы = {sum}");
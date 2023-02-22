// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//1. Ввод числа
int Number(string figure)
{
    Console.Write(figure);
    string matter = Console.ReadLine();
    int result = Convert.ToInt32(matter);
    return result;
}

//2. Метод для возведения в куб
int N = Number("Введите число: ");
for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"{i} * {i} * {i} = {i * i * i}");
}

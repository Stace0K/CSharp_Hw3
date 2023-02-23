//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//1. Ввод числа
int Number(string figure)
{
    Console.Write(figure);
    string matter = Console.ReadLine();
    int result = Convert.ToInt32(matter);
    return result;
}


//2. Проверка на пятизначность
bool FiveFigure(int numb)
{
    while (numb > 99999 || numb < 10000)
    {
        Console.WriteLine("Не похоже на пятизначное число");
        return false;
    }
    return true;
}

//3. Разворот числа
int Reverse(int figure)
{
    int result = 0;
    while (figure > 0)
    {
        result = result * 10 + figure % 10;
        figure = figure / 10;
    }
    return result;
}

//4. Проверка на истинность условия
void Palindrome(int nu1, int nu2)
{
    if (nu1 == nu2)
    {
        Console.WriteLine("Это палиндром");
    }
    else Console.WriteLine("Это не палиндром");
}

//5. Результат
int a = Number("Введите пятизначное число: ");
if (FiveFigure(a))
{
    int rev = Reverse(a);
    Palindrome(a, rev);
}
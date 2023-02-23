//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double x1, y1, z1;
double x2, y2, z2;

Console.WriteLine("Введите координаты точек: ");

Console.Write("x1: ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1: ");
y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z1: ");
z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("x2: ");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2: ");
y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z2: ");
z2 = Convert.ToDouble(Console.ReadLine());


double Distance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dist = Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0), 0.5);
    Console.WriteLine("Расстояние между точками равно " + dist);
    return dist;
}

double distance = Distance(x1, y1, z1, x2, y2, z2);
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите две точки А ");
Console.WriteLine("Введите две точки B ");
double xb = Convert.ToUInt32(Console.ReadLine());
double xa = Convert.ToUInt32(Console.ReadLine());
double yb = Convert.ToUInt32(Console.ReadLine());
double ya = Convert.ToUInt32(Console.ReadLine());
double result = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));

Console.Write(result);
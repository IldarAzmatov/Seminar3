//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите три точки А ");
Console.WriteLine("Введите три точки B ");
double xa = Convert.ToUInt64(Console.ReadLine());
double xb = Convert.ToUInt64(Console.ReadLine());
double ya = Convert.ToUInt64(Console.ReadLine());
double yb = Convert.ToUInt64(Console.ReadLine());
double ca = Convert.ToUInt64(Console.ReadLine());
double cb = Convert.ToUInt64(Console.ReadLine());
double result = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((cb - ca), 2));
double Result = Math.Round(result , 2);

Console.Write(Result);
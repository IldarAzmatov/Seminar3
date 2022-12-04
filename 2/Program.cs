//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
    Console.WriteLine("X-от 1 до бесконечности Y- от 1 бесконечности");
    break;
    case 2:
    Console.WriteLine("X-от -1 до бесконечности Y- от 1 бесконечности");
    break;
    case 3:
    Console.WriteLine("X-от -1 до бесконечности Y- от -1 бесконечности");
    break;
    case 4:
    Console.WriteLine("X-от 1 до бесконечности Y- от -1 бесконечности");
    break;
    default:
    Console.WriteLine("Такой нет четверти");
    break;
}
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// y=ax+c y=bx+d
// x=(d-c)/(a-b) y=a(d-c)/(a-b)+c=(ad-bc)/(a-b).

Console.WriteLine("Введите угловой коэффициент k1 первой прямой: ");
double k1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите координату точки пересечения с осью y первой прямой b1: ");
double b1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите угловой коэффициент k2 второй прямой, не равный первой: ");
double k2 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите координату точки пересечения с осью y второй прямой b2: ");
double b2 = Convert.ToInt64(Console.ReadLine());
if (k2-k1==0) Console.WriteLine("Прямые параллельны");
else
{
double X0 = (b2-b1)/(k1-k2);
double Y0 = (k1*b2-k2*b1)/(k1-k2);
Console.WriteLine($"Точка пересечения имеет координаты ({X0},{Y0}) ");
}

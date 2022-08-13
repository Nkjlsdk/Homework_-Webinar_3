//ввести координаты двух точек 2D и найти расстояние между точками А(3,6) В (2,1) - 5,09
Console.WriteLine("Введите координату Х точки А");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Х точки B");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((Math.Pow(x1-x2,2))+(Math.Pow((y1-y2),2)));/// sqrt- корень квар-ый, Pow - возведение в кв, Math - библиотека мат формул

Console.WriteLine($"AB= {Math.Round(result,2)}"); //Math.Round(result,2) функция округления, 2 в () - до второго знака
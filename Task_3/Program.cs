/// по № четверть сист.координат  определить координаты положительные/отрицательные 
Console.WriteLine("Введите номер четверти системы координат:");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter == 1)  Console.WriteLine(" x > 0 && y > 0");
if (quarter == 2)  Console.WriteLine(" x < 0 && y > 0");
if (quarter == 3)  Console.WriteLine(" x < 0 && y < 0");
if (quarter == 4)  Console.WriteLine(" x > 0 && y < 0");
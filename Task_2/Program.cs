// ввод координат точки по ним нужно определить четверть сист.координат  
Console.WriteLine("Введите координату по оси оX:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по оси оY:");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)  Console.WriteLine("I четверть");
if (x < 0 && y > 0)  Console.WriteLine("II четверть");
if (x < 0 && y < 0)  Console.WriteLine("III четверть");
if (x > 0 && y < 0)  Console.WriteLine("IV четверть");
// Ввод координат двух точек и поиск расстояния между ними в 3D пространстве
int pointBx = new Random().Next(1,100);
int pointAx = new Random().Next(1,100);
int pointBy = new Random().Next(1,100);
int pointAy = new Random().Next(1,100);
int pointBz = new Random().Next(1,100);
int pointAz = new Random().Next(1,100);
double result = Math.Sqrt(Convert.ToInt32(Math.Pow((pointBx-pointAx), 2))+Convert.ToInt32(Math.Pow((pointBy-pointAy), 2))+Convert.ToInt32(Math.Pow((pointBz-pointAz), 2)));
Console.WriteLine($"A ({pointAx}, {pointAy}, {pointAz}); В ({pointBx}, {pointBy}, {pointBz})");
Console.WriteLine($"AB= {result:0.00}");

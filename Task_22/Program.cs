// Ввести число N, вывести ряд квадратов чисел от 1 до N
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
for (int count = 1; count<=N; count++) Console.WriteLine(Math.Pow(count,2));//for подобна while

// Ввести число N, вывести ряд квадратов чисел от 1 до N
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int count  = 1;
while (count<=N)
{
    Console.WriteLine(Math.Pow(count,2));
    count++;
}
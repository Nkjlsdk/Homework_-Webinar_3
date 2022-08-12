// Ввод числа N и вывод кубов чисел от 1 до N
int numberN = new Random().Next(1,10);
int count = 0;
int stepen = 3;
Console.Write($"{numberN}- ");
while (count<numberN)
{
        Console.Write($"{Math.Pow(count+1, stepen) } ");
        count++;
}
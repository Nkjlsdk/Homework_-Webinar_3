// Программа принимает на вход пятизначное число, приверяет является ли оно палиндром
int number = new Random().Next(10000, 100000);
if (number/1000==(number%100)%10*10+((number%100))/10)
{
    Console.WriteLine($"{number} да");
}
else
{
    Console.WriteLine($"{number} нет");
}
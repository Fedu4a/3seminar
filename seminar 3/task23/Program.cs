//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int a = 0;
while (a <= number)
{
    double cube = Math.Pow(a, 3);
    Console.Write($" {cube} ");
    a += 1;
}
//Напишите программу, которая на вход принимает число и выдает, 
//является ли число четным (делится ли оно на два без остатка).

Console.Write("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2)
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");
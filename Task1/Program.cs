// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int summa = 0;

while (num > 0)
{
    int i = num % 10;
    num = num / 10;
    summa = summa + i;
}
Console.Write("Сумма цифр числа  = " + summa );


//  Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.


Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввежите второе число: ");
int num2 =Convert.ToInt32(Console.ReadLine());


int degree = num1;

for (int i = 1; i < num2; i++)
{
    degree = degree * num1;
}
Console.WriteLine($"{num1} в степени {num2} равно: " + degree);


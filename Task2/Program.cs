// Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.


int[] NewArray()
{
int[] array = new int[8];
for (int i = 0; i <= 7; i++)
{
    array[i] = new Random().Next(0, 1000); // сделал до 1000 
}


    return array;
}

int[] array = NewArray();

for (int i = 0; i <= 7; i++)
{
    Console.Write($" {array [i]}, ");
}

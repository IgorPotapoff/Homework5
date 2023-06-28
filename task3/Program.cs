/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];

void CreateArray(int size)
{
Random rand = new Random();
for (int i = 0; i <size; i++)
{
array[i] = rand.NextDouble();
Console.Write($"{array[i]:F2} ");
}

}

double dif(double[] array)
{
int i = 1;
double min = array[0];
double max = array[0];

while (i< array.Length)
{
if (max<array[i])
max = array[i];
if (min>array[i])
min = array[i];
i++;
}
return max-min;
}

CreateArray(size);
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {dif(array):F2}");
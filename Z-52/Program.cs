//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int m= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
FillArray(array);
Print(array);
SumArray(array);

void SumArray(int[,] arr1)
{
  for (int j = 0; j < arr1.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            
            sum = sum+arr1[i, j];
        }
    sum = sum / m;
    Console.WriteLine($"Среднее арифметическое столбца {j}: {sum}");  
    }
}



int[,] FillArray(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
arr[i, j] = new Random().Next(-99, 100);
}
}
return arr;
}

void Print(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
Console.Write($"{arr[i, j]} ");
}
Console.WriteLine();
}
}
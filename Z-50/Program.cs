// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите позиции элемента массива который необходимо найти");
Console.WriteLine("Введите строку: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбц");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[3, 4];
FillArray(array);
Print(array);
NumberArray(array);

void NumberArray(int[,] arr1)
{
    if(m > arr1.GetLength(0)||n > arr1.GetLength(1))
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"Число находящееся массиве {arr1[m, n]}");
    }
}

// void NumberArray(int[,] arr1)
// {
//   for (int i = 0; i < arr1.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr1.GetLength(1); j++)
//         {
//             if(arr1[i, j] > arr1[m, n]|| arr1[i, j] < arr1[m, n])
//             {
//                 Console.WriteLine("Такого числа в массиве нет");
//             }
//             else
//             {
//                 Console.WriteLine(arr1[i, j]);
//             }
//         }
//     }
// }


int[,] FillArray(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
arr[i, j] = i + j;
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
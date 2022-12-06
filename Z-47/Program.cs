//  Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Random x = new Random();

// double r = Convert.ToDouble(x.Next(-100, 100)/10.0);
// Console.WriteLine (r);


Console.WriteLine("Введите количество строк");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int number2 = Convert.ToInt32(Console.ReadLine());

double[,] arrayTable = new double[ number1, number2 ];

Random x = new Random();

for (int i = 0; i < arrayTable.GetLength(0); i++)
{
for (int j = 0; j < arrayTable.GetLength(1); j++)
{
arrayTable[i,j] = Convert.ToDouble(x.Next(-100, 100)/10.0);
Console.Write($"{arrayTable[i,j]} ");
}
Console.WriteLine();
}

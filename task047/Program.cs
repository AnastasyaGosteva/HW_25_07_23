static void GreateArray(int line, int column)
{
    double[,] newArray = new double[line, column];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = Math.Round((new Random().Next(1, 10) + new Random().NextDouble()), 2);
            Console.Write($"{newArray[i, j]}" + "\t", -2);
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк в будущем массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в будущем массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
GreateArray(n, m);


void calculationArithmeticMean(int[,] array)
{
    double summ = 0;
    double srArithmetic = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        summ = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            summ = summ + array[j, i];
        }
        srArithmetic = Math.Round(summ / array.GetLength(0), 2);
        if ( i != array.GetLength(1) - 1) Console.Write($"{srArithmetic}; ");
        else Console.Write($"{srArithmetic}.");
    }
}

void printArray(int[,] array)
{
    Console.Clear();
    Console.WriteLine("Ваш массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} " + "\t", -2);
        }
        Console.WriteLine();
    }
}

static int[,] GreateArray(int line, int column)
{
    int[,] newArray = new int[line, column];
    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = new Random().Next(1, 10);
    return newArray;
}

Console.Write("Введите количество строк в будущем массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в будущем массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = GreateArray(n, m);
printArray(array);
calculationArithmeticMean(array);
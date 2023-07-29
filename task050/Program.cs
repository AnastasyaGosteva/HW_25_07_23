void searchNumber(int[,] array, int number)
{
    string text = "Искомое число " + number + " не присутствует в данном массиве.";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (number == array[i, j])
            {
                text = "Искомое число " + number + " присутствует в данном массиве.";
                break;
            }
        }
    }
    Console.WriteLine(text);
}

static void PushArray(int[,] array)
{
    Console.Clear();
    Console.WriteLine("Ваш массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}" + "\t", -2);
        }
        Console.WriteLine();
    }
}

static int[,] GreateArray(int line, int column)
{
    int[,] newArray = new int[line, column];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Clear();
            Console.WriteLine("Преступим к заполнению массива!");
            Console.Write("Проинициализируйте элемент массива: ");
            newArray[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return newArray;
}

Console.Write("Введите количество строк в будущем массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в будущем массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = GreateArray(n, m);
PushArray(array);
Console.Write("Введите число, которое необходимо найти в сформированном массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
searchNumber(array, number);

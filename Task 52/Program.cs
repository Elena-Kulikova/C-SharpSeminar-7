// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < matrix.GetLength(0); i++) // rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //cols
        {
            matrix[i, j] = rand.Next(0, 21);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++) // rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //cols
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    
}

double[] GetArithmeticMean(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
            result[j] = Math.Round(sum / matrix.GetLength(1),2);
        }
    }
    return result;
}

void PrintArray(double[] matrix)
{
    System.Console.WriteLine("--------------------------------------------------");
    System.Console.WriteLine("Среднее арифметическое каждого столбца составляет: ");
    for (int i = 0; i < matrix.Length; i++)
    {
        System.Console.Write(matrix[i] + "\t");
    }
}

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов  матрицы: ");
System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
double[] arithmeticMean = GetArithmeticMean(myMatrix);
PrintArray(arithmeticMean);
System.Console.WriteLine();
System.Console.WriteLine();
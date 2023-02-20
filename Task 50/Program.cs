// Задача 50. Напишите программу, которая на вход принимает позиции
//  элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

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

int[] FindNumberPosition(int[,] matrix, int number)
{
    int[] position = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                position[0] = i + 1;
                position[1] = j + 1;
                return position;
            }
        }
    }
    position[0] = -1;
    position[1] = -1;
    return position;
}

void PrintPosition(int[] pos, int num)
{
    System.Console.WriteLine();
    if (pos[0] > 0 && pos[1] > 0) System.Console.WriteLine($"Число {num} находится в {pos[0]}-й строке, {pos[1]}-м столбце");
    else System.Console.WriteLine($"Число {num} отсутствует в заданном массиве");
    System.Console.WriteLine();
}

int GetNumerToFind()
{
    System.Console.WriteLine();
    System.Console.Write("Введите число:   ");
    string writeNumber = Console.ReadLine();
    int number = Convert.ToInt32(writeNumber);
    return number;
}


int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов  матрицы: ");
System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
int number = GetNumerToFind();
int[] position = FindNumberPosition(myMatrix, number);
PrintPosition(position, number);
// Найти произведение двух матриц
Console.WriteLine("Введите колличество столбцов первой матрицы и строк второй матрицы");
int columnRows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите колличество строк первой матрицы");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов второй матрицы");
int columns = int.Parse(Console.ReadLine());


int [,] FillArray(int rows, int columns)
{
    int [,] array = new int [rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,3}", array[i, j]);
        }
    Console.WriteLine();
    }
}
int [,] MatrixProduct(int [,] arrayFirst, int [,] arraySecond)
{
    int arraySum = 0;
    int [,] arrayThird = new int [arrayFirst.GetLength(0), arraySecond.GetLength(1)];
    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arraySecond.GetLength(1); j++)
        {
            for (int k = 0; k < arrayFirst.GetLength(1); k++)
            {
                arraySum = arraySum + (arrayFirst[i,k] * arraySecond[k,j]);
            }
        arrayThird[i, j] = arraySum;
        arraySum = 0;
        }
    }
    return arrayThird;
}

int [,] firstArray = FillArray(rows, columnRows);
int [,] secondArray = FillArray(columnRows, columns);

Console.WriteLine($"Первая матрица. Строк = ({rows}), столбцов = ({columnRows}):");
PrintArray(firstArray);
Console.WriteLine();
Console.WriteLine($"(Вторая матрица. Строк = ({columnRows}), столбцов = ({columns}):");
PrintArray(secondArray);
int [,] thirdArray = MatrixProduct(firstArray, secondArray);
Console.WriteLine();
Console.WriteLine($"Произведение матриц. Строк = ({rows}), столбцов = ({columns}):");
PrintArray(thirdArray);
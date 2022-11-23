// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента.
void FillArray(int[,,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(min, max);
            }
}

void PrintArray (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int k = 0; k < array.GetLength(2); k++)
           {
            Console.Write($"|{j}| {array[i, j, k]}; ");
           }
           Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int Elemetnumber (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int a = Elemetnumber("Введите размер первого массива ");
int b = Elemetnumber("Введите размер второго массива ");
int c = Elemetnumber("Введите размер третьего массива ");

int[,,] array = new int[a, b, c];
FillArray(array, 0, 30);
Console.WriteLine("Массив ");
PrintArray(array);
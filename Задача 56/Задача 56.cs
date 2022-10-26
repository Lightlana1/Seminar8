// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void Task56() 
{ 
    Random random = new Random(); 
    int rows = 4; 
    int columns = 4; 
    int[,] numbers = new int[rows, columns]; 

    FillArray(numbers);
    PrintArray (numbers);
    Console.WriteLine();
    
    int sum = 0;
    int[] num2 = new int [rows];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sum = sum + numbers[i, j];
        }

        num2[i] = sum; 

        Console.WriteLine();
        Console.Write($"Сумма строки с индексом {i} = {sum}");

    }

    Console.WriteLine();
    Console.WriteLine();

    int min = num2[0];
    int index_n = 0;
    for (int n = 0; n < rows; n++)
    {
        if (min > num2[n])
        {
            min = num2[n];
            index_n = n;
        }
    }

    Console.Write($"Строка с наименьшей суммой элементов: {index_n + 1}-я");

} 

void FillArray(int[,] numbers)
{
    Random random = new Random(); 
    int rows =  numbers.GetLength(0); // строки 
    int columns = numbers.GetLength(1); // колонки 

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(); 
        }  
    }
}

void PrintArray (int[,] numbers)
{
    int rows =  numbers.GetLength(0); // строки 
    int columns = numbers.GetLength(1); // колонки

    Console.WriteLine("Задан массив:"); 
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t"); 
        } 
        Console.WriteLine(); 
    }
}

Task56();
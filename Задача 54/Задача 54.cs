void Task54() 
{ 
    Random random = new Random(); 
    int rows = random.Next(4, 5); 
    int columns = random.Next(4, 5); 
        
    int[,] numbers = new int[rows, columns]; 

    FillArray(numbers);
    PrintArray (numbers);
    Console.WriteLine();

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            for (int z = 0; z < numbers.GetLength(1) - 1; z++)
            {
                int min = 0;
                if (numbers [i, z] > numbers[i, z+1])
                {
                    min = numbers [i, z];
                    numbers [i, z] = numbers[i, z+1];
                    numbers[i, z+1] = min;
                }
            }
        }
    }



Console.WriteLine("Массив с упорядоченными значениями:");
PrintArray (numbers);

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
            numbers[i, j] = random.Next(0, 11); 
        }  
    }
}

void PrintArray (int[,] numbers)
{
    int rows =  numbers.GetLength(0); // строки 
    int columns = numbers.GetLength(1); // колонки

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t"); 
        } 
        Console.WriteLine(); 
    }
}

Task54();
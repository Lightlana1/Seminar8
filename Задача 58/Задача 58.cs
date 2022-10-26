// Напишите программу, которая заполнит спирально массив 4 на 4.
void Task58() 
{ 
    int size = 4; 
    int[,] numbers = new int[size, size]; 

    int index = 0; 

    int currentRow = 0;
    int currentColumn = 0;

    int indexRow = 0;
    int indexCol = 1;

    int steps = size;
    int turn = 0;

    while (index < numbers.Length)
    {
        numbers[currentRow, currentColumn] = index + 1;
        
        index++;
        steps--;
        if (steps == 0)
        {
            steps = size - 1 - turn/2;
            // steps = rows * ((turn+1)%2) + columns * (turn%2) - 1 turn / 2;
            int temp  = indexRow;
            indexRow = indexCol;
            indexCol = -temp;
            turn++;
        }

        currentRow += indexRow;
        currentColumn += indexCol;

    }

    PrintArray(numbers);

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

Task58();
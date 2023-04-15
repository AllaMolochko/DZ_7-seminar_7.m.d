//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
//массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [5,5];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
        {        
            for (int b = 0; b < array.GetLength(1); b++)
            {
                array [a,b] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        Console.Write("[");
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write(array[a,b] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}

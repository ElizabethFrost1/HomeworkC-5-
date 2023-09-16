//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
int size = GetNumber("Введите размерность массива: ");
int min = GetNumber("Введите минимальное число массива: ");
int max = GetNumber("Введите максимальное число массива: ");
int [] numbers = new int[size];

GetArray(numbers);
PrintArray(numbers);
int maxGetArray = numbers[0];
int minGetArray = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > maxGetArray)
    {
        maxGetArray = numbers[i];
    }
    if (numbers[i] < minGetArray)
    {
        minGetArray = numbers[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {maxGetArray - minGetArray}");

void GetArray(int [] array)
{ 

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int GetNumber(string message)  
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


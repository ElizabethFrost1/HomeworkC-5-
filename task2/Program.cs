int size = GetNumber("Введите размерность массива: ");
int min = GetNumber("Введите минимальное число массива: ");
int max = GetNumber("Введите максимальное число массива: ");
int [] numbers = new int[size];

GetArray(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0)
    {
        result += numbers[i];
    }
}
Console.WriteLine($"Сумма элементов нечетных позиций = {result}");

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


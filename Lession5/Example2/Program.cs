﻿Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z += 2)
    sum = sum + numbers[z];

Console.WriteLine($"Cумма элементов на нечётных позициях {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
}


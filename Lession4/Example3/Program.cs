// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (ввод элеменетов через консоль??)

// Я не понимаю что от меня требуется.. Вот string.Split())
Console.Write("Напишите массив из 8 элементов через запятую ");
string words = Console.ReadLine();

foreach (var a in words.Split(','))
{
    Console.Write(a);
}

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int length = 8;
int[] array = new int[length];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите элемент массива под индексом " + i + ": ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if (i != array.Length - 1)
    {
        Console.Write(", ");
    }
}
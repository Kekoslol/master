
using System;

class Program
{
    static void Main()
    {
        // Ввод массива вручную или используем готовый массив
        string[] inputArray = { "123", "hello", "hi", ":-)", "world", "OK" };

        // Подсчитываем количество строк, длина которых <= 3
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужной длины
        string[] resultArray = new string[count];
        int index = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        // Вывод результата
        Console.WriteLine("Новый массив строк (длина <= 3):");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }
}

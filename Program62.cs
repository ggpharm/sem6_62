// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


    int n = 4; // Размер массива (4x4)
    int[,] spiralArray = new int[n, n];

    int num = 1; // Значение для заполнения
    int rowStart = 0, rowEnd = n - 1, colStart = 0, colEnd = n - 1;

        while (num <= n * n)
        {
            // Заполняем верхнюю строку
            for (int i = colStart; i <= colEnd; i++)
            {
                spiralArray[rowStart, i] = num++;
            }
            rowStart++;

            // Заполняем последний столбец
            for (int i = rowStart; i <= rowEnd; i++)
            {
                spiralArray[i, colEnd] = num++;
            }
            colEnd--;

            // Заполняем нижнюю строку
            for (int i = colEnd; i >= colStart; i--)
            {
                spiralArray[rowEnd, i] = num++;
            }
            rowEnd--;

            // Заполняем первый столбец
            for (int i = rowEnd; i >= rowStart; i--)
            {
                spiralArray[i, colStart] = num++;
            }
            colStart++;
        }

        // Выводим массив на экран
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{spiralArray[i, j]:D2} ");
            }
            Console.WriteLine();
        }

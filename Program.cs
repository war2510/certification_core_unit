﻿{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

        string[] resultArray = GetStringsLengthLessThanOrEqualThree(inputArray);

        Console.WriteLine("Результат:");
        Console.WriteLine(string.Join(", ", resultArray));
    }

    static string[] GetStringsLengthLessThanOrEqualThree(string[] inputArray)
    {
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

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

        return resultArray;
    }
}

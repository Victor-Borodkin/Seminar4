// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// System.Console.WriteLine("Введите 2 числа: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int mult = num;
// for (int i = 2; i <= num2; i++)
// {
//     num *= mult;
// }
// System.Console.WriteLine($"Получится: {num} ");


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int Sum(int number)
// {   int count = 0;
//     while (number != 0)
//     {
//         int digit = number%10;
//         count += digit;
//         number = number/10;
//     }
//     return count;
// }

// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = Sum(num);
// System.Console.WriteLine($"Сумма цифр в числе {num} = {result}");


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] Array = new int[8];

for (int i = 0; i < 8; i++)
{
    Array[i] = new Random().Next(1, 10);
    Console.Write(Array[i] + " ");
}


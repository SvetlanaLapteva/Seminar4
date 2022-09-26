// void Zadacha26();
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// {
//     int number = 1234322;
//     int current = number;
//     int count = 0;
//     while (current > 0)
//     {
//         current = current /10;
//         count = count + 1;
//     }
//     Console.WriteLine($"Количество цифр в числе {number} = {count}");
// }

// Zadacha26();

void Task26()
            {
                Console.WriteLine("\n \t Task 24");
                Console.Write("Enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{num} -> {Math.Ceiling(Math.Log10(num))}");
            }
            Task26();

Console.Clear();
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int number = new Random().Next(10,100);
// Console.WriteLine(number);

// if (number/10 > number%10)
// {
// Console.WriteLine(number/10);
// }
// else
// {
// Console.WriteLine(number%10);
// }


// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int number = new Random().Next(100,1000);
// Console.WriteLine(number);
// string num = Math.Abs(number).ToString();


// Console.Write(num[0]);
// Console.Write(num[2]);

// // или

// Console.WriteLine(($"{num[0]}{num[2]}"));

// // или



// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a % b == 0)
// {
//     Console.WriteLine("Кратно");
// }

// else
// {
//     Console.WriteLine($"Не кратно, остаток {a % b} ");
// }


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// или с рандомом
// int a = new Random().Next(1, 10000);
// Console.WriteLine(a);

// if ((a % 7 == 0) && (a % 23 == 0))
// {
//     Console.WriteLine("Кратно одновременно 7 и 23");
// }

// else
// {
//     Console.WriteLine($"Не кратно, одновременно 7 и 23 ");
// }

//  Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 == num2 * num2)
// {
//     Console.Write("Первое число - это квадрат второго числа");
// }
// else if (num2 == num1 * num1)
// {
//     Console.Write("Второе число - это квадрат первого числа");
// }
// else 
// {
//     Console.Write("Квадратов числа нет");
// }
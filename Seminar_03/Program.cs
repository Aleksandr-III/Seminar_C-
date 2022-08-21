Console.Clear();

// // разбор ДЗ
// // Третье число
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 0)
// {
//     number = number * -1;
// }
// if (number > 0 && number < 100)
// {
//     Console.WriteLine("Третей цифры нет");
// }
// else 
// {
//     while (number > 999)     // цикл до тех пор пока не станет 3 - х значным
//     {
//         number = number / 10;
//     }
//     int thirdNumber = number % 10;
//     Console.WriteLine("Третья цифра " + thirdNumber);
// }

// ещё решение 


// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// if(Math.Abs(num) < 100)
// {
//     Console.Write("Третей цифры нет");
// }

// else 
// {
//     while(Math.Abs(num) >= 1000)
//     {
//         num = num/10;
//     }
//     Console.Write(Math.Abs(num = num%10));
// }

// // Напишите программу  которая принимает на вход цифру, обозначивающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 7 || num < 1)
// {
//     Console.WriteLine("Неверный день недели");
// }
// if (num > 5)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// // или 

// Console.WriteLine("Введите цифру соответсвующую дню недели:");
// int day = Convert.ToInt32(Console.ReadLine());

// int result = day % 7;

// switch (result)
// {
//     case 1: Console.Write($"{day} является понедельником"); break;
//     case 2: Console.Write($"{day} является вторником"); break;
//     case 3: Console.Write($"{day} является средой"); break;
//     case 4: Console.Write($"{day} является четвергом"); break;
//     case 5: Console.Write($"{day} является пятницей"); break;
//     case 6: Console.Write($"Ура {day} является субботним выходным"); break;
//     case 0: Console.Write($"Ура {day} является воскресным выходным"); break;
//     default: break;
// }

// // или 

// int num = new Random().Next(1, 1000);
// Console.WriteLine($"Imput number = {num}");

// int daysofWeek = num < 8 ? num : (num % 7 == 0 ? 7 : num % 7);
// Console.WriteLine($"daysOfWeek = {daysofWeek}");

// switch (daysofWeek)
// {
//     case 1: 
//     case 2: 
//     case 3: 
//     case 4: 
//     case 5: Console.Write("No. Todey is workday"); break;
//     case 6: 
//     case 0: Console.Write("Yes. Todey is weekend"); break;
// }

// Напишите программу которая принимает на вход координаты точки ( X и Y), причём

// Console.WriteLine("Введите координаты x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("Первая четверть");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Вторая четверть");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("Третья четверть");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("Четвёртая четверть");
// }
// else
// {
//     Console.WriteLine("Определить четверть не возможно");
// }

// или 
// void printQuarter(int a, int b)
// {
    
// if (a > 0 && b > 0)
// {
//     Console.WriteLine("Первая четверть");
// }
// else if (a < 0 && b > 0)
// {
//     Console.WriteLine("Вторая четверть");
// }
// else if (a < 0 && b < 0)
// {
//     Console.WriteLine("Третья четверть");
// }
// else if (a > 0 && b < 0)
// {
//     Console.WriteLine("Четвёртая четверть");
// }
// else
// {
//     Console.WriteLine("Определить четверть не возможно");
// }
// }




// Console.WriteLine("Введите координаты x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y");
// int y = Convert.ToInt32(Console.ReadLine());
// printQuarter(x, y);

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти: ");
// int x = Convert.ToInt32(Console.ReadLine());

// if (x == 1)
// {
//     Console.WriteLine("Первая четверть x > 0 , y > 0");
// }
// else if (x == 2)
// {
//     Console.WriteLine("Вторая четверть x < 0 , y > 0");
// }
// else if (x == 3)
// {
//     Console.WriteLine("Третья четверть x < 0 , y < 0");
// }
// else if (x == 4)
// {
//     Console.WriteLine("Четвёртая четверть x > 0 , y < 0");
// }
// else
// {
//     Console.WriteLine("Четверть не существует");
// }

// или 

// void diapason(int q)
// {
//     switch (q)
//     {
//         case 1: Console.Write("x > 0 , y > 0"); break;
//         case 2: Console.Write("x < 0 , y > 0"); break;
//         case 3: Console.Write("x < 0 , y < 0"); break;
//         case 4: Console.Write("x > 0 , y < 0"); break;
//         default: Console.Write("Четверть не существует"); break;
//     }
// }

// Console.WriteLine("Введите номер четверти от 1 до 4: ");
// int quart = Convert.ToInt32(Console.ReadLine());
// diapason(quart);


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.


// double length_otr(int a, int b, int c, int d)
// {
//     double l = Math.Sqrt((a-c)*(a-c)+(b-d)*(b-d));
//     return l;
// }


// Console.WriteLine("Введите координаты первой точки по x");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты первой точки по y");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты второй точки по x");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки по y");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double Length = length_otr(x1, y1, x2, y2);
// Console.Write ($"{Length} расстояние между точками");

// или

Console.WriteLine("Введите Х1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите У1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Х2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите У2: ");
int y2 = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1 - y2, 2));

Console.WriteLine($"d={d:f2}");  // форматирование цифры {d:f2} значит остаток выведет только 2 числа

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// void sq(int x)
// {
//     int count = 1;
//     while ( count <= x)
//     {
//         Console.Write($"{(Math.Pow(count, 2))} ");
//         count++;
//     }
// }

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// sq(a);

// или\

// Console.WriteLine("Введите число");
// int N = int.Parse(Console.ReadLine());
// for(int i = 1; i <= N; i++)  // (от i ; до i = N ; и какой шаг(в данном случае +1))
// {
//     Console.Write($"{i*i} ");
// }
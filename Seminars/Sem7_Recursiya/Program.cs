﻿// Семинар 7. Рекурсия
// Задание 1
// Напишите программу которая будет принимать на вход число и возвращть сумму его цифр.
// Указание
// Использовать рекурсию
// Пример
// 123 => 6
// 63 => 9

// 1. n = 5 -> 1 2 3 4 5            - Если писать по простому, пишется через обычный цикл и вывод через Console

// Пример рекурсии, с вводом числа

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// void OneToN(int n)
// {
//     if(n > 0)
//     {
//         OneToN(n - 1);
//         Console.Write(n + " ");
//     }
// }
// OneToN(n);


// Возвращаемся к нашему заданию 1.
Console.WriteLine("Введите число: ");
 int n = Convert.ToInt32(Console.ReadLine());
int SumOfDigits(int num)    //456
{
    if (num > 0)
    {
        return num % 10 + SumOfDigits(num / 10);
    }
    return 0;       // Некая заглушка, в любом случае нужно написать return
}
Console.WriteLine(SumOfDigits(n));

// Задание 2
// Напишите программу, которая принимает на вход 2 числа A и В, и возводит число А в целую степень В с помощью рекурсии
// Пример
// А = 3; В = 5 - >  243 (3 в 5 степени)
// А = 2; В = 3 - >  8 (2 в 3 степени)
// Решение

// Console.WriteLine("Введите число А: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число В: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int Pow(int a, int b)
// {
//     if (a == 1) return 1;
//     if (b == 0) return 1;
//     return a * Pow(a, b - 1);
// }

// Console.WriteLine(Pow(a, b));

// Разбор решения:
// Если идти последовательно то мы сравниваем числа по условиям, к примеру:
//  3 = 1 - > Нет;
//  5 = 0 - > Нет;

// Действие 1. Значит 3 * ? =
// Срабатывает b - 1, в данном примере это становится равным 4
// Снова
// 3 = 1 - > Нет;
// 4 = 0 - > Нет;
// Действие 2. Значит 3 * ? =
// Срабатывает b - 1, в данном примере это становится равным 3
// Снова
// 3 = 1 - > Нет;
// 3 = 0 - > Нет;
// Действие 3. Значит 3 * ? =
// Срабатывает b - 1, в данном примере это становится равным 2
// Снова
// 3 = 1 - > Нет;
// 2 = 0 - > Нет;
// Действие 4. Значит 3 * ? =
// Срабатывает b - 1, в данном примере это становится равным 1
// Снова
// 3 = 1 - > Нет;
// 1 = 0 - > Нет;
// Действие 5. Значит 3 * ? =
// Срабатывает b - 1, в данном примере это становится равным 0
// Снова
// 3 = 1 - > Нет;
// 3 = 0 - > Да;
// Действие 6. При совпадении условия возвращает  (b = 1) Значит 3 * 1 = 3(и данная цифра идет как множитель вверх по действиям(3*3=9;9*3=27;27*3=81;81*3=243 - конец действий))
// Срабатывает b - 1, в данном примере это становится равным 2

// ДЗ сдаем в репозитории пушим файл Program.cs
// Архивы, тексты, картинки и прочее приниматься не будут
// по заданию 1 - все просто, делали такую задачу просто добавляется ещё одно условие
// по заданию 2 - узнаем что за функция Аккермана и делаем тоже самое
// по заданию 3 - 
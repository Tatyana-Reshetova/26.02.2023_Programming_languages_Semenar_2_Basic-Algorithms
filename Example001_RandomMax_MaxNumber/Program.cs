// Напишите программу, которая выводит случайное число из отрезка
//[10,99]
// и показывает наибольшую цифру числа.
// 78 -> 7 8 max = 8
Console.Clear();

int num = new Random().Next(10,100); //num = 78
int a1 = num / 10; // 78/10 = 7
int a2 = num % 10; // 78 % 10 = 8
int max = a1;
if (max<a2)
    max = a2;
Console.WriteLine ($"Максимальная цифра числа {num} -> {max}");    


﻿/* Напишите цикл, который принимает на вход два числа (A и B) и возводит 
число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.WriteLine("Введите число которое возводим в степень ");
int numA = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Введите степень ");
int numB = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine($"{exponentiation(numA, numB)}");

int exponentiation(int numA, int numB){
    int result = 1;
    for(int i = 0; i <= numB-1; i++){
        result = result * numA;
    }
    return result;
}



/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

//Console.WriteLine("Введите число ");
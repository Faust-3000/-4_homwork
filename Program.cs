/* Напишите цикл, который принимает на вход два числа (A и B) и возводит 
число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

/*Console.WriteLine("Введите число которое возводим в степень ");
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
}*/



/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

/* Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр вашем числе, {GetSum(num)}");

int GetSum(int number){
    int sum = 0;
    while(number > 0){
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
} */

/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] array = GetBinnaryArray(8);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] GetBinnaryArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next();
    }
    return result;
}
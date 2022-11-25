// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//МЕТОДЫ
//метод сложения элементов в заданном промежутке.
int SumNaturalNumbers(int numМ, int numN)
{
    if (numМ <= numN) return numN + SumNaturalNumbers(numМ, numN - 1);
    else return 0;
}

//ПРОГРАММА
Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

//проверка ввода, для возможности расчета даже, если м больше n.
if (m > n) (m,n) = (n,m);

//вывод результата.
int result = SumNaturalNumbers(m, n);
Console.Write($"{result} ");
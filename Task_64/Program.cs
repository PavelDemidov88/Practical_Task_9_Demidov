// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

Main();

void Main()
{
    int numM = Prompt("Введите число М: ");
    int numN = Prompt("Введите  число N: ");
    if (numM < numN)
    {
        Print(numM, numN);
    }
    else
    {
        Print(numN, numM);
    }
}
 int Prompt(string message)
 {
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
 }
 void Print(int current, int value)
 {
    if (current > value) return;
    Console.Write($"{current} ");
    Print(current+1, value);
 }
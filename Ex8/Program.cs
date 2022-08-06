/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int A = 2;
while(A <= N)
    {
    Console.Write(A);
    Console.Write(" ");
    A = A + 2;
    }
if (N < 2)
    {
    Console.WriteLine("нет ответа, введенное число должно быть больше или равно 2");
    }
    